using CliWrap;
using iTunesLib;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace Audio_Master
{
    public class Downloader
    {
        private static readonly string s_TempDirectoryPath = 
            Path.Combine(Directory.GetCurrentDirectory(), "Temp");
        private readonly YoutubeClient _client = new YoutubeClient();
        private readonly Cli _ffmpegCli = new Cli("ffmpeg.exe");
        private iTunesApp _iTunes = new iTunesApp();

        private MediaStreamInfo GetBestAudioStreamInfo(MediaStreamInfoSet set)
        {
            if (set.Audio.Any())
                return set.Audio.WithHighestBitrate();
            if (set.Muxed.Any()) 
                return set.Muxed.WithHighestVideoQuality();
            throw new Exception("No applicable media streams found for this video");
        }

        public string GetCreatePath(string pathStart, string pathEnd)
        {
            string path = $"{pathStart.TrimEnd('/')}//{pathEnd.TrimStart('/')}";
            string[] dirs = Directory.GetDirectories(pathStart);
            if (!dirs.Contains(path))
                Directory.CreateDirectory(path);
            return path;
        }

        public async Task Download(Song s = null, List<Song> songs = null)
        {
            Song song = s == null ? songs[0] : s;

            string path = String.Empty;
            string album = song.Album;
            string artist = song.Artist;
            string id = song.ID;
            string name = song.Video.Title;
            string cleanTitle = GetCleanTitle(name);

            MediaStreamInfoSet set = await _client.GetVideoMediaStreamInfosAsync(id);
            MediaStreamInfo streamInfo = set.Audio.WithHighestBitrate();

            // download to temp file
            Directory.CreateDirectory(s_TempDirectoryPath);
            string streamFileExt = streamInfo.Container.GetFileExtension();
            string streamFilePath = Path.Combine(s_TempDirectoryPath, $"{Guid.NewGuid()}.{streamFileExt}");
            await _client.DownloadMediaStreamAsync(streamInfo, streamFilePath);

            // Create directories          
            if (String.IsNullOrEmpty(artist))
            {
                path = GetCreatePath(Settings.MusicPath, "Unknown Artist");
                if (String.IsNullOrEmpty(album))
                    path = GetCreatePath(path, "Unknown Album");
            }
            else
            {
                path = GetCreatePath(Settings.MusicPath, artist);
                if (!String.IsNullOrEmpty(album))
                    path = GetCreatePath(path, album);
            }

            string mp3Path = $"{path}\\{cleanTitle}.mp3";

            // Convert to mp3
            try
            {
                _ffmpegCli.SetArguments($"-i \"{streamFilePath}\" -q:a 0 -map a \"{mp3Path}\" -y");
                await _ffmpegCli.ExecuteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }       

            // delete temp file
            File.Delete(streamFilePath);

            // save/split mp3
            using (TagLib.File meta = TagLib.File.Create(mp3Path))
            {
                if (s != null)
                {
                    s.Path = mp3Path;
                    SaveMp3(meta, s);
                }
                else
                {
                    meta.Tag.Album = song.Album;
                    meta.Save();
                    Split(songs, path, mp3Path);
                }
            }           
        }

        private string GetCleanTitle(string name)
        {
            return Path.GetInvalidFileNameChars()
                .Aggregate(name, (current, c) => current.Replace(c.ToString(), String.Empty));
        }

        private TagLib.IPicture[] GetTagLibPicture(Image image)
        {
            var bytes = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
            return new TagLib.IPicture[] { new TagLib.Picture(new TagLib.ByteVector(bytes)) };
        }

        public void SaveMp3(TagLib.File meta, Song s, bool needSplit = false)
        {
            // Set tags

            meta.Tag.Title = s.Name;

            if (!String.IsNullOrEmpty(s.Artist))
                meta.Tag.Performers = new string[] { s.Artist };

            if (!String.IsNullOrEmpty(s.Album))
                meta.Tag.Album = s.Album;

            if (!String.IsNullOrEmpty(s.Year))
                meta.Tag.Year = Convert.ToUInt32(s.Year);

            if (!String.IsNullOrEmpty(s.Grouping))
                meta.Tag.Grouping = s.Grouping;

            if (!String.IsNullOrEmpty(s.Genre))
                meta.Tag.Genres = new string[] { s.Genre };  
            
            if (!String.IsNullOrEmpty(s.Lyrics))
                meta.Tag.Lyrics = s.Lyrics;

            if (s.TrackNumber != 0)
                meta.Tag.Track = Convert.ToUInt32(s.TrackNumber);

            if (s.Image != null)
                meta.Tag.Pictures = GetTagLibPicture(s.Image);

            meta.Save();

            _iTunes.LibraryPlaylist.AddFile(@s.Path);

            // Sometimes split songs will have an incorrect duration in iTunes.
            // They need to be converted in iTunes to fix it.
            if (needSplit)
            {
                var index = _iTunes.LibraryPlaylist.Tracks.Count;
                var iTunesSeconds = _iTunes.LibraryPlaylist.Tracks[index].Duration;

                while (_iTunes.ConvertOperationStatus != null) { }

                if (iTunesSeconds != s.Time.TotalSeconds)
                {
                    _iTunes.LibraryPlaylist.Tracks[index].Delete();
                    _iTunes.ConvertFile(@s.Path);                   
                    s.Converted = true;
                }
            }
        }

        public void Split(List<Song> songs, string folderPath, string mp3Path)
        {
            try
            {
                #region Get FPS by total frames
                //double totalFrames = 0;
                //TimeSpan ts;
                //using (Mp3FileReader reader = new Mp3FileReader(@mp3Path))
                //{
                //    ts = reader.TotalTime;
                //    Mp3Frame mp3Frame = reader.ReadNextFrame();
                //    while (mp3Frame != null)
                //    {
                //        totalFrames++;
                //        mp3Frame = reader.ReadNextFrame();
                //    }
                //}
                //double fps = totalFrames / ts.TotalSeconds;
                #endregion

                // Get the amount of frames in the file per second of the track

                double framesPerSecond = 0;
                using (Mp3FileReader reader = new Mp3FileReader(@mp3Path))
                {
                    Mp3Frame frame = reader.ReadNextFrame();
                    framesPerSecond = 
                        Convert.ToDouble(frame.SampleRate) / Convert.ToDouble(frame.SampleCount);
                }

                // Calculate starting frames for each track

                foreach (Song s in songs)
                    s.StartFrames = s.StartSeconds * framesPerSecond;

                for (int i = 0; i < songs.Count; i++)
                {
                    using (Mp3FileReader reader = new Mp3FileReader(@mp3Path))
                    {
                        string trackNum = songs[i].TrackNumber.ToString();
                        if (trackNum.Length == 1)
                            trackNum = "0" + trackNum;

                        string cleanTitle = GetCleanTitle(songs[i].Name);

                        songs[i].Path = $"{folderPath}\\{trackNum} {cleanTitle}.mp3";

                        int count = 0;
                        Mp3Frame mp3Frame = reader.ReadNextFrame();
                        var fs = new FileStream(@songs[i].Path, FileMode.Create, FileAccess.Write);

                        while (mp3Frame != null)
                        {
                            // TODO Test refactor

                            //if (songs[i].StartFrames <= count && i == songs.Count - 1)
                            //    fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                            //else if (songs[i].StartFrames <= count && songs[i + 1].StartFrames > count)
                            //    fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                            if (songs[i].StartFrames <= count && 
                                (i == songs.Count - 1 || songs[i + 1].StartFrames > count))
                                fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                            mp3Frame = reader.ReadNextFrame();
                            count++;
                        }

                        fs.Close();
                    }
                }

                foreach (Song s in songs)
                {
                    using (var meta = TagLib.File.Create(@s.Path))
                        SaveMp3(meta, s, true);

                    while (_iTunes.ConvertOperationStatus != null) { }

                    if (s.Converted)
                        File.Delete(@s.Path);
                }

                File.Delete(@mp3Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
