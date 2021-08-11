using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YoutubeExplode;
using Kaztep.Extensions;

namespace Audio_Master
{
    public class Scraper
    {
        public static HtmlWeb Web = new HtmlWeb();
        public static HtmlAgilityPack.HtmlDocument Document = new HtmlAgilityPack.HtmlDocument();
        private List<string> _webSongs = new List<string>();
        private List<string> _webLyrics = new List<string>();
        private List<string> _webTimes = new List<string>();
        private readonly YoutubeClient _client = new YoutubeClient();
        private Dictionary<string, string> _lyrics = new Dictionary<string, string>();
        private Timer _timer = new Timer();
        private int _ticks = 0;

        public Scraper(frmMain m)
        {
            _timer.Tick += Timer_Tick;
        }

        public Dictionary<string, string> ScrapeWiki(string url)
        {
            var dictionary = new Dictionary<string, string>();
            Document = Web.Load(url);

            HtmlNode node = SelectNode("image");
            string imageUrl = node.OuterHtml.Remove(0, node.OuterHtml.IndexOf("upload.wikimedia"));
            imageUrl = "https://" + imageUrl.Remove(imageUrl.IndexOf("\""));
            GetImage(imageUrl);

            dictionary.Add("Artist", SelectNode("contributor").InnerText);
            dictionary.Add("Album", SelectNode("summary album").InnerHtml);

            string yearText = SelectNode("published").InnerText;
            yearText = yearText.Remove(0, yearText.Length - 4);

            dictionary.Add("Year", yearText);

            return dictionary;
        }

        private HtmlNode SelectNode(string c)
        {
            return Document.DocumentNode.SelectNodes($"//*[@class='{c}']")[0];
        }

        public Dictionary<string, string> ScrapeArchives()
        {
            var doc = Program.MainForm.GetBrowser().Document;
            var dictionary = new Dictionary<string, string>();

            if (doc == null)
                return dictionary;

            // open lyrics
            foreach (HtmlElement el in doc.GetElementsByTagName("a"))
            {
                if (el.Id != null && el.Id.Contains("lyricsButton"))
                    el.InvokeMember("onclick");
            }

            foreach (HtmlElement el in doc.GetElementsByTagName("h2"))
            {
                dictionary.Add("Artist", el.InnerText);
                break;
            }

            foreach (HtmlElement el in doc.GetElementsByTagName("h1"))
            {
                dictionary.Add("Album", el.InnerText);
                break;
            }

            // get year
            foreach (HtmlElement el in doc.GetElementsByTagName("dd"))
            {
                if (el.InnerHtml != null && el.OuterHtml.ContainsAny(", ", "19", "20"))
                {
                    var year = el.InnerHtml.Remove(0, el.InnerHtml.Length - 5).TrimEnd(' ');
                    dictionary.Add("Year", year);
                    break;
                }
            }

            if (dictionary.ContainsKey("Album"))
            {
                // get type
                foreach (HtmlElement el in doc.GetElementsByTagName("dd"))
                {
                    if (el.InnerHtml.Contains("EP"))
                    {
                        dictionary["Album"] += " (EP)";
                        break;
                    }
                }
            }

            // get songs
            foreach (HtmlElement el in doc.GetElementsByTagName("td"))
            {
                if (el.OuterHtml.Contains("wrapWords"))
                    _webSongs.Add(el.InnerHtml.TrimEnd(1).Replace("&amp;", "&"));
            }

            // get web times
            foreach (HtmlElement el in doc.GetElementsByTagName("td"))
            {
                if (el.InnerHtml != null && el.OuterHtml.Contains("<TD align=right>"))
                    _webTimes.Add(el.InnerHtml);

                else if (_webTimes.Count == _webSongs.Count)
                    break;
            }

            // get image
            string html = String.Empty;
            foreach (HtmlElement el in doc.GetElementsByTagName("a"))
            {
                if (el.OuterHtml.Contains("id=cover"))
                    html = el.OuterHtml;
            }

            string url = String.Empty;
            foreach (string s in html.Split(' '))
            {
                if (!s.StartsWith("href"))
                    continue;

                url = s.Remove(0, 6);
                url = url.Remove(url.Length - 1);
                if (!url.ContainsAny(".jpg", ".gif", ".jpeg"))
                    url = url + ".jpg";
                break;
            }

            if (url == String.Empty)
                return dictionary;

            GetImage(url);

            // Scrape lyrics in 3 seconds...
            _timer.Start();

            return dictionary;
        }

        private string GetImageUrlFromArchives(System.Windows.Forms.HtmlDocument doc)
        {
            string html = String.Empty;
            foreach (HtmlElement el in doc.GetElementsByTagName("a"))
            {
                if (el.OuterHtml.Contains("id=cover"))
                {
                    html = el.OuterHtml;
                    break;
                }
            }

            string url = String.Empty;
            foreach (string s in html.Split(' '))
            {
                if (!s.StartsWith("href"))
                    continue;

                url = s.Remove(0, 6);
                url = url.Remove(url.Length - 1);
                if (!url.ContainsAny(".jpg", ".gif", ".jpeg"))
                    url += ".jpg";
                break;
            }

            return url;
        }
   
        public void GetImage(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 50000;
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            Image i = Image.FromStream(stream);
            Program.MainForm.GetPictureBox().Image = i;
            webResponse.Close();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            // Delay 3 seconds to ensure that lyrics have loaded (might need more time).
            _ticks++;
            if (_ticks < 30) 
                return;
            
            _timer.Stop();
            _ticks = 0;

            ScrapeLyrics(); 
        }

        private void ScrapeLyrics()
        {
            foreach (HtmlElement el in Program.MainForm.GetBrowser().Document.GetElementsByTagName("td"))
            {
                if (el.Id != null && el.Id.Contains("lyrics_"))
                {
                    if (el.InnerText != "(loading lyrics...)")
                        _webLyrics.Add(el.InnerText.Remove(0, 1));

                    else if (el.InnerText.ToLower().Contains("instrumental"))
                        _webLyrics.Add("Instrumental");

                    else
                        _webLyrics.Add("NA");
                }
            }

            if (_webLyrics.Count != _webSongs.Count)
            {
                MessageBox.Show("Web lyrics and song count mismatch!");
                return;
            }

            foreach (string s in _webSongs)
            {
                if (!Program.MainForm.Lyrics.ContainsKey(s))
                    Program.MainForm.Lyrics.Add(s, _webLyrics[_webSongs.IndexOf(s)]);
            }

            Program.MainForm.SetAddButtonEnabled(true);
            _webSongs = new List<string>();
            _webLyrics = new List<string>();
            _webTimes = new List<string>();
        }
    }
}
