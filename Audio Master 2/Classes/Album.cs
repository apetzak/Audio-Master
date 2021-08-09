using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
        public bool NeedsSplit = false;
        public Image Image;
        public string Directory;
        public int NullCount;
        public int NACount;
        public string URL;
        private DataGridView _grid;

        public Album(DataGridView dgv = null)
        {
            _grid = dgv;
        }

        public Album(string directory, string artist, string name)
        {
            Directory = directory;
            Artist = artist;
            Name = name;
            URL = String.Format("https://www.metal-archives.com/albums/{0}/{1}", Artist, Name);

            var d = new DirectoryInfo(Directory);
            FileInfo[] Files = d.GetFiles();

            foreach (FileInfo file in Files)
            {
                if (file.Name.EndsWith(".mp3") || file.Name.EndsWith(".m4a"))
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
                {
                    _s.TrackNumber = i;
                    i++;
                }
            }

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

            _grid.Rows[index].DefaultCellStyle.BackColor = SystemColors.Window;
            _grid.Sort(this._grid.Columns["cTrackNumber"], ListSortDirection.Ascending);         

            foreach (DataGridViewRow dgvr in _grid.Rows)
            {
                if (dgvr.DefaultCellStyle.BackColor == Color.Red)
                {
                    _grid.Rows.Remove(dgvr);
                    _grid.Rows.Add(dgvr);
                }
            }
        }

        // calculate time for each song after starting times are set
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
                        totalSeconds = Convert.ToInt32(times[0]) * 60 + Convert.ToInt32(times[1]);
                    else if (times.Length == 3)
                        totalSeconds = Convert.ToInt32(times[0]) * 3600 + Convert.ToInt32(times[1]) * 60 + Convert.ToInt32(times[2]);               
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

//public class Date
//{
//    private int month = 7;  // Backing store

//    public int Month
//    {
//        get
//        {
//            return month;
//        }
//        set
//        {
//            if ((value > 0) && (value < 13))
//            {
//                month = value;
//            }
//        }
//    }
//}