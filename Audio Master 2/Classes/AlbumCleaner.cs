using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Audio_Master
{
    public class AlbumCleaner
    {
        public static void Clean()
        {
            var dict = new Dictionary<string, string>();
            string path = Settings.MusicPath;

            string[] artists = Directory.GetDirectories(path);
            foreach (string ar in artists)
            {
                string[] albums = Directory.GetDirectories(ar);
                foreach (string al in albums)
                {
                    List<Song> songs = new List<Song>();

                    foreach (string file in Directory.GetFiles(al))
                    {
                        if (!file.EndsWith(".mp3") && !file.EndsWith(".mp4"))
                            continue;

                        using (TagLib.File meta = TagLib.File.Create(file))
                        {
                            ImageConverter ic = new ImageConverter();
                            object o = null;
                            if (meta.Tag.Pictures.Count() > 0)
                                o = meta.Tag.Pictures[0];

                            if (o == null)
                                o = "";

                            string gen = "";
                            if (meta.Tag.Genres.Count() > 0)
                                gen = meta.Tag.Genres[0];

                            string group = "";
                            if (meta.Tag.Grouping != null)
                                group = meta.Tag.Genres[0];

                            string art = "";
                            if (meta.Tag.Performers.Count() > 0)
                                art = meta.Tag.Performers[0];

                            Song s = new Song()
                            {
                                Name = meta.Tag.Title,
                                Artist = art,
                                Album = meta.Tag.Album,
                                Year = meta.Tag.Year.ToString(),
                                Genre = gen,
                                Grouping = group,
                                TrackNumber = Convert.ToInt32(meta.Tag.Track),
                                StartTime = o.ToString(),
                                DiscNumber = Convert.ToInt32(meta.Tag.Disc.ToString())
                            };
                            songs.Add(s);
                        }
                    }

                    string artist = String.Empty, album = String.Empty, composer = String.Empty,
                           year = String.Empty, genre = String.Empty, grouping = String.Empty,
                           image = String.Empty;

                    string reason = "";

                    int i = 1;
                    foreach (Song s in songs)
                    {
                        if (s.DiscNumber == 2 && s.TrackNumber == 1)
                            i = 1;

                        if (s.TrackNumber != i)
                        {
                            //reason += "track number, ";
                        }
                        i++;
                    }

                    foreach (Song s in songs)
                    {
                        if (songs.IndexOf(s) != 0)
                        {
                            if (s.Artist != artist || String.IsNullOrEmpty(artist))
                                reason += "artist, ";
                            if (s.Album != album || String.IsNullOrEmpty(album))
                                reason += "album, ";
                            if (s.Composer != composer)
                                reason += "composer, ";
                            if (s.Year != year)
                                reason += "year, ";
                            if (s.Genre != genre || String.IsNullOrEmpty(genre))
                                reason += "genre, ";
                            if (s.Grouping != grouping)
                                reason += "grouping, ";
                            if (s.StartTime != image || String.IsNullOrEmpty(image))
                                reason += "image, ";
                        }

                        artist = s.Artist;
                        album = s.Album;
                        composer = s.Composer;
                        year = s.Year;
                        genre = s.Genre;
                        grouping = s.Grouping;
                        image = s.StartTime;
                    }

                    reason = reason.TrimEnd().TrimEnd(',');

                    if (!String.IsNullOrEmpty(reason) && !String.IsNullOrEmpty(artist))
                    {
                        dict.Add(artist + " : " + album, reason);
                        break;
                    }
                }
            }
        }
    }
}
