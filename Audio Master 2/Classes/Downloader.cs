using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Models;
using YoutubeExplode.Models.MediaStreams;
using System.Text.RegularExpressions;
using CliWrap;
using NAudio.Wave; 
using iTunesLib;
using System.Diagnostics;
using System.Collections.Generic;

namespace Audio_Master
{
    public class Downloader
    {
        private readonly YoutubeClient client = new YoutubeClient();
        private readonly Cli FfmpegCli = new Cli("ffmpeg.exe");
        private static readonly string TempDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Temp");
        iTunesApp iTunes = new iTunesApp();

        private MediaStreamInfo GetBestAudioStreamInfo(MediaStreamInfoSet set)
        {
            if (set.Audio.Any())
                return set.Audio.WithHighestBitrate();
            if (set.Muxed.Any()) 
                return set.Muxed.WithHighestVideoQuality();
            throw new Exception("No applicable media streams found for this video");
        }

        public void CorrectGenre(Album a)
        {
            //string path = String.Format(@"{0}{1}.mp3", a.Directory, a.Songs[0].Name);
            //var f = TagLib.File.Create(path);

            //if (f.Tag.Genres[0] != a.Genre)
            //{

            //}
        }

        public string GetPath(string pathStart, string pathEnd)
        {
            string path = String.Format(@"{0}{1}", pathStart, pathEnd);
            string[] dirs = Directory.GetDirectories(pathStart);
            if (!dirs.Contains(path))
                Directory.CreateDirectory(path);
            return path;
        }

        public async Task Download(Song s = null, List<Song> songs = null)
        {
            string path = String.Empty;
            string album = s == null ? songs[0].Album : s.Album;
            string artist = s == null ? songs[0].Artist : s.Artist;
            string id = s == null ? songs[0].ID : s.ID;
            string name = s == null ? songs[0].Video.Title : s.Video.Title;
            string cleanTitle = Path.GetInvalidFileNameChars().Aggregate(name, (current, c) => current.Replace(c.ToString(), String.Empty));
            MediaStreamInfoSet set = await client.GetVideoMediaStreamInfosAsync(id);
            MediaStreamInfo streamInfo = set.Audio.WithHighestBitrate();

            // download to temp file
            Directory.CreateDirectory(TempDirectoryPath);
            string streamFileExt = streamInfo.Container.GetFileExtension();
            string streamFilePath = Path.Combine(TempDirectoryPath, $"{Guid.NewGuid()}.{streamFileExt}");
            await client.DownloadMediaStreamAsync(streamInfo, streamFilePath);

            // create directories          
            if (String.IsNullOrEmpty(artist))
            {
                path = GetPath(Settings.MusicPath, "Unknown Artist");
                if (String.IsNullOrEmpty(album))
                    path = GetPath(path, "Unknown Album");
            }
            else
            {
                path = GetPath(Settings.MusicPath, artist);
                if (!String.IsNullOrEmpty(album))
                    path = GetPath(path, album);
            }

            string mp3Path = String.Format(@"{0}\{1}.mp3", path, cleanTitle);

            // convert to mp3
            try
            {
                FfmpegCli.SetArguments($"-i \"{streamFilePath}\" -q:a 0 -map a \"{mp3Path}\" -y");
                await FfmpegCli.ExecuteAsync();
            }
            catch (Exception e)
            {

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
                    meta.Tag.Album = songs[0].Album;
                    meta.Save();
                    Split(songs, path, mp3Path);
                }
            }           
        }

        public void SaveMp3(TagLib.File meta, Song s, bool needSplit = false)
        {
            //clear sorting

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
                meta.Tag.Pictures = new TagLib.IPicture[] { new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(s.Image, typeof(byte[])))) };
            meta.Save();
            iTunes.LibraryPlaylist.AddFile(@s.Path);

            if (needSplit)
            {
                var iTunesSeconds = iTunes.LibraryPlaylist.Tracks[iTunes.LibraryPlaylist.Tracks.Count].Duration;

                while (iTunes.ConvertOperationStatus != null) { }

                if (iTunesSeconds != s.Time.TotalSeconds)
                {
                    iTunes.LibraryPlaylist.Tracks[iTunes.LibraryPlaylist.Tracks.Count].Delete();
                    iTunes.ConvertFile(@s.Path);                   
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

                double framesPerSecond = 0;
                using (Mp3FileReader reader = new Mp3FileReader(@mp3Path))
                {
                    Mp3Frame mp3Frame = reader.ReadNextFrame();
                    framesPerSecond = Convert.ToDouble(mp3Frame.SampleRate) / Convert.ToDouble(mp3Frame.SampleCount);
                }

                foreach (Song s in songs)
                    s.StartFrames = s.StartSeconds * framesPerSecond;

                for (int i = 0; i < songs.Count; i++)
                {
                    using (Mp3FileReader reader = new Mp3FileReader(@mp3Path))
                    {
                        string track = songs[i].TrackNumber > 9 ? songs[i].TrackNumber.ToString() : "0" + songs[i].TrackNumber.ToString();
                        string cleanTitle = Path.GetInvalidFileNameChars().Aggregate(songs[i].Name, (current, c) => current.Replace(c.ToString(), String.Empty));
                        songs[i].Path = String.Format("{0}\\{1} {2}.mp3", folderPath, track, cleanTitle);
                        int count = 0;
                        Mp3Frame mp3Frame = reader.ReadNextFrame();
                        FileStream fs = new FileStream(@songs[i].Path, FileMode.Create, FileAccess.Write);

                        while (mp3Frame != null)
                        {
                            if (songs[i].StartFrames <= count && i == songs.Count - 1)
                                fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                            else if (songs[i].StartFrames <= count && songs[i + 1].StartFrames > count)
                                fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                            mp3Frame = reader.ReadNextFrame();
                            count++;
                        }

                        fs.Close();
                    }
                }

                int n = 0;
                foreach (Song s in songs)
                {
                    n++;
                    using (var meta = TagLib.File.Create(@s.Path))
                    {
                        SaveMp3(meta, s, true);
                    }
                    while (iTunes.ConvertOperationStatus != null) { }
                    if (s.Converted == true)
                        File.Delete(@s.Path);
                }

                File.Delete(@mp3Path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
