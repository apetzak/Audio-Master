using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YoutubeExplode;

namespace Audio_Master
{
    public class Scraper
    {
        public static HtmlWeb Web = new HtmlWeb();
        public static HtmlAgilityPack.HtmlDocument Document = new HtmlAgilityPack.HtmlDocument();
        private frmMain _frmMain;
        private List<string> _webSongs = new List<string>();
        private List<string> _webLyrics = new List<string>();
        private List<string> _webTimes = new List<string>();
        private readonly YoutubeClient _client = new YoutubeClient();
        private Dictionary<string, string> _lyrics = new Dictionary<string, string>();

        public Scraper(frmMain m)
        {
            _frmMain = m;
            timer.Tick += Timer_Tick;
        }

        public void ScrapeWiki(string url)
        {
            Document = Web.Load(url);

            HtmlNode node = SelectNode("image");
            string imageUrl = node.OuterHtml.Remove(0, node.OuterHtml.IndexOf("upload.wikimedia"));
            imageUrl = "https://" + imageUrl.Remove(imageUrl.IndexOf("\""));
            GetImage(imageUrl);

            _frmMain.txtArtist.Text = SelectNode("contributor").InnerText;
            _frmMain.txtAlbum.Text = SelectNode("summary album").InnerHtml;

            string yearText = SelectNode("published").InnerText;
            _frmMain.txtYear.Text = yearText.Remove(0, yearText.Length - 4);
        }

        private HtmlNode SelectNode(string c)
        {
            return Document.DocumentNode.SelectNodes($"//*[@class='{c}']")[0];
        }

        public void ScrapeArchives()
        {
            var doc = _frmMain.browser.Document;

            if (_frmMain.browser.Document == null)
                return;

            // open lyrics
            foreach (HtmlElement el in doc.GetElementsByTagName("a"))
            {
                if (el.Id != null && el.Id.Contains("lyricsButton"))
                    el.InvokeMember("onclick");
            }

            // get artist
            if (_frmMain.txtArtist.Text == "")
            {
                foreach (HtmlElement el in doc.GetElementsByTagName("h2"))
                    _frmMain.txtArtist.Text = el.InnerText;
            }

            // get album name
            if (_frmMain.txtAlbum.Text == "")
            {
                foreach (HtmlElement el in doc.GetElementsByTagName("h1"))
                    _frmMain.txtAlbum.Text = el.InnerText;
            }

            // get year
            foreach (HtmlElement el in doc.GetElementsByTagName("dd"))
            {
                if (el.InnerHtml != null && el.OuterHtml.Contains(", ") || el.OuterHtml.Contains("19") || el.OuterHtml.Contains("20"))
                {
                    _frmMain.txtYear.Text = el.InnerHtml.Remove(0, el.InnerHtml.Length - 5).TrimEnd(' ');
                    break;
                }
            }

            // get type
            foreach (HtmlElement el in doc.GetElementsByTagName("dd"))
            {
                if (el.InnerHtml.Contains("EP"))
                {
                    _frmMain.txtAlbum.Text = _frmMain.txtAlbum.Text + " (EP)";
                    break;
                }
            }
          
            // get songs
            foreach (HtmlElement el in doc.GetElementsByTagName("td"))
            {
                if (el.OuterHtml.Contains("wrapWords"))
                    _webSongs.Add(el.InnerHtml.Remove(el.InnerHtml.Length - 1).Replace("&amp;", "&"));
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
            string html = "";
            foreach (HtmlElement el in doc.GetElementsByTagName("a"))
            {
                if (el.OuterHtml.Contains("id=cover"))
                    html = el.OuterHtml;
            }

            string url = "";
            foreach (string s in html.Split(' '))
            {
                if (!s.StartsWith("href"))
                    continue;
                
                url = s.Remove(0, 6);
                url = url.Remove(url.Length - 1);
                if (!url.Contains(".jpg") && !url.Contains(".gif") && !url.Contains(".jpeg"))
                    url = url + ".jpg";
                break;            
            }

            if (url == "")
                return;

            GetImage(url);

            // Scrape lyrics in 3 seconds...
            timer.Start();
        }
   
        public void GetImage(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 50000;
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            Image i = Image.FromStream(stream);
            _frmMain.pbCoverArt.Image = i;
            webResponse.Close();
        }

        public Timer timer = new Timer();
        public int ticks = 0;
        public void Timer_Tick(object sender, EventArgs e)
        {
            // Delay 3 seconds to ensure that lyrics have loaded (might need more time).
            ticks++;
            if (ticks < 30) 
                return;
            
            timer.Stop();
            ticks = 0;

            ScrapeLyrics(); 
        }

        private void ScrapeLyrics()
        {
            foreach (HtmlElement el in _frmMain.browser.Document.GetElementsByTagName("td"))
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
                if (!_frmMain.Lyrics.ContainsKey(s))
                    _frmMain.Lyrics.Add(s, _webLyrics[_webSongs.IndexOf(s)]);
            }

            _frmMain.btnAdd.Enabled = true;
            _webSongs = new List<string>();
            _webLyrics = new List<string>();
            _webTimes = new List<string>();
        }
    }
}
