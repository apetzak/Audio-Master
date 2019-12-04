using System;
using System.Drawing;
using YoutubeExplode.Models;
using System.Collections.Generic;

namespace Audio_Master
{
    public class Song
    {
        public string Album;
        public string Artist;
        public string Bitrate;
        public string Composer;
        public int DiscNumber;
        public string Genre;
        public string Grouping;
        public string ID;
        public string Lyrics;
        public string Name;
        public TimeSpan Time;
        public int TrackNumber;
        public string StartTime;
        public int StartSeconds;
        public double StartFrames;
        public int RowIndex;
        public Video Video;
        public Image Image;
        public string Year;

        // Comments

        public bool Converted = false;
        public string Path = "";
        public bool NeedsSplit = false;
        public string Status;

        public Song()
        {

        }

        public Song(string name, string lyrics, int trackNumber, string time)
        {
            //Name = name;
            //Lyrics = lyrics;
            //TrackNumber = trackNumber;
            //Time = time;
        }

        public Song(string name, int trackNumber, string id, string startTime)
        {
            Name = name.Replace("?", "_");
            TrackNumber = trackNumber;
            ID = id;
            SetStartTime(startTime);
            Lyrics = "NA";
        }

        public void SetStartTime(string s)
        {
            if (s == null || !s.Contains(":"))
                return;
            s = s.Replace(" ", "");
            StartTime = s;

            if (StartTime == "00:00")
                return;

            int minutes = 0;
            int seconds = 0;

            if (s.ToString().Length > 5)
            {
                var array = StartTime.Split(':');
                int hours = Convert.ToInt32(array[0]);
                minutes = Convert.ToInt32(array[1]) + (hours * 60);
                seconds = Convert.ToInt32(array[2]);
            }
            else
            {
                minutes = Convert.ToInt32(StartTime.Remove(2));
                if (StartTime.Remove(0, 3).Length > 2)
                    StartTime = StartTime.Remove(StartTime.Length - 1);
                seconds = Convert.ToInt32(StartTime.Remove(0, 3));
            }
            StartSeconds = seconds + (minutes * 60);
        }
    }
}
