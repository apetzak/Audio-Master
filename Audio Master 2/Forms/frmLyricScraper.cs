﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Audio_Master
{
    public partial class frmLyricScraper : Form
    {
        public List<Album> Albums = new List<Album>();
        public int CurrentIndex = 0;

        public frmLyricScraper()
        {
            InitializeComponent();
            timer.Interval += 10;
            timer.Tick += WebTimer_Tick;

            var artistDirectories = Directory.GetDirectories(Settings.MusicPath);

            foreach (string s in artistDirectories)
            {
                string artist = s.Remove(0, 46);
                var albumDirectories = Directory.GetDirectories(Settings.MusicPath + artist);
                foreach (string a in albumDirectories)
                    Albums.Add(new Album(a, artist, a.Remove(0, 47 + artist.Length)));
            }

            foreach (Album a in Albums)
            {
                if (a.NullCount > 0)
                {
                    CurrentIndex = 0;
                    webBrowser1.Navigate(a.URL);
                    txtURL.Text = a.URL;
                    timer.Start();
                    break;
                }
                CurrentIndex++;
            }
        }

        public Timer timer = new Timer();
        public int delay = 0;
        public void WebTimer_Tick(object sender, EventArgs e)
        {
            delay++;
            if (delay == 10)
            {
                timer.Stop();
                delay = 0;

                foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("a"))
                    if (el.Id != null && el.Id.Contains("lyricsButton"))
                        el.InvokeMember("onclick");

                btnNext.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;

            List<string> webSongs = new List<string>();
            List<string> webLyrics = new List<string>();

            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("td"))
                if (el.OuterHtml.Contains("wrapWords"))
                    webSongs.Add(el.InnerHtml.Remove(el.InnerHtml.Length - 1));

            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("td"))
                if (el.Id != null && el.Id.Contains("lyrics_"))
                    webLyrics.Add(el.InnerText.ToString().Remove(0, 1));

            foreach (string s in Albums[CurrentIndex].songs)
            {
                string song = s.Remove(0, 3);
                song = song.Remove(song.Length - 4);
                song = song.Replace("_", "?");

                int albumIndex = 0;
                foreach (string st in webSongs)
                {
                    if (st.ToLower() == song.ToLower() || st.ToLower().Contains(song.ToLower()) || song.ToLower().Contains(st.ToLower()))
                    {
                        string path = String.Format(@"{0}\{1}", Albums[CurrentIndex].Directory, s);
                        var file = TagLib.File.Create(path);
                        file.Tag.Lyrics = webLyrics[albumIndex];
                        if (file.Tag.Lyrics == "loading lyrics...)")
                            file.Tag.Lyrics = "NA";
                        file.Save();
                        break;
                    }
                    albumIndex++;
                }
            }
            Next();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            Next();
        }

        public void Next()
        {
            CurrentIndex++;

            if (Albums[CurrentIndex].NullCount > 0)
            {
                webBrowser1.Navigate(Albums[CurrentIndex].URL);
                txtURL.Text = Albums[CurrentIndex].URL;
                timer.Start();
            }
            else
                Next();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtURL.Text = webBrowser1.Url.ToString();
            Album a = Albums[CurrentIndex];
            lblDetails.Text = String.Format("Count: {0}, Null: {1}, NA: {2}", a.songs.Count, a.NullCount, a.NACount);
            timer.Start();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("a"))
                if (el.Id != null && el.Id.Contains("lyricsButton"))
                    el.InvokeMember("onclick");
        }
    }
}
