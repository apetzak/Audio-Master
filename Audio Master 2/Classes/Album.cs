using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kaztep.Extensions;

namespace Audio_Master
{
    public class Album
    {
        public List<Song> Songs = new List<Song>();
        public List<string> SongTitles = new List<string>();
        public string Name;
        public string Artist;
        public string Genre;
        public string Grouping;
        public int Year;
        public string ID;
        public string Time;
        public Image Image;
        public bool NeedsSplit = false;
        public string Directory;
        public int NullCount;
        public int NACount;
        public string Url;
        private readonly DataGridView _grid;

        public Album(DataGridView dgv = null)
        {
            _grid = dgv;
        }

        public Album(string directory, string artist, string name)
        {
            Directory = directory;
            Artist = artist;
            Name = name;
            Url = String.Format("https://www.metal-archives.com/albums/{0}/{1}", Artist, Name);

            var d = new DirectoryInfo(Directory);
            FileInfo[] Files = d.GetFiles();

            foreach (FileInfo file in Files)
            {
                if (file.Name.EndsWithAny(".mp3", ".m4a"))
                    SongTitles.Add(file.Name);
            }

            if (SongTitles.Count == 0)
                return;

            foreach (string s in SongTitles)
            {
                var f = TagLib.File.Create(String.Format(@"{0}\{1}", Directory, s));

                if (f.Tag.Lyrics == null)
                    NullCount++;
                else if (f.Tag.Lyrics == "NA")
                    NACount++;
            }
        }

        public void Add(Song s)
        {
            Songs.Add(s);
            bool hasLyrics = s.Lyrics.Equals("NA") ? false : true;
            _grid.Rows.Add(s.TrackNumber, s.Name, s.Time, hasLyrics, s.ID, s.StartTime);
            _grid.Rows[s.TrackNumber - 1].Cells[3].ToolTipText = s.Lyrics;
        }

        public void Insert(Song s, int index)
        {
            if (s.TrackNumber - 1 > Songs.Count)
            {
                s.TrackNumber = Songs.Count + 1;
                Songs.Add(s);
            }
            else
            {
                Songs.Insert(s.TrackNumber - 1, s);

                int i = 1;
                foreach (Song _s in Songs)
                    _s.TrackNumber = i++;
            }

            SetTrackNumbersOnGrid();

            _grid.Rows[index].DefaultCellStyle.BackColor = SystemColors.Window;
            _grid.Sort(_grid.Columns["cTrackNumber"], ListSortDirection.Ascending);

            foreach (DataGridViewRow dgvr in _grid.Rows)
            {
                if (dgvr.DefaultCellStyle.BackColor == Color.Red)
                {
                    _grid.Rows.Remove(dgvr);
                    _grid.Rows.Add(dgvr);
                }
            }
        }

        private void SetTrackNumbersOnGrid()
        {
            foreach (Song _s in Songs)
            {
                foreach (DataGridViewRow dgvr in _grid.Rows)
                {
                    if (dgvr.Cells[1].Value.ToString() == _s.Name)
                    {
                        dgvr.Cells[0].Value = _s.TrackNumber;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Calculate time for each song after starting times are set.
        /// </summary>
        public void SetTimes()
        {
            int i = 0;
            foreach (Song s in Songs)
            {
                int seconds = 0;
                try
                {
                    seconds = Songs[i + 1].StartSeconds - Songs[i].StartSeconds;
                }
                catch // last song
                {
                    var times = Time.Split(':');
                    int totalSeconds = 0;

                    if (times.Length == 2)
                        totalSeconds = times[0].ToInt() * 60 + times[1].ToInt();
                    else if (times.Length == 3)
                        totalSeconds = times[0].ToInt() * 3600 + times[1].ToInt() * 60 + times[2].ToInt();
                    
                    seconds = totalSeconds - Songs[i].StartSeconds;
                }
                int minutes = 0;
                while (seconds > 60)
                {
                    minutes++;
                    seconds -= 60;
                }
                //s.Time = String.Format("{0}:{1}", minutes >= 10 ? minutes.ToString() : "0" + minutes.ToString(), seconds >= 10 ? seconds.ToString() : "0" + seconds.ToString());
                _grid.Rows[i++].Cells[2].Value = s.Time;
            }
        }
    }
}