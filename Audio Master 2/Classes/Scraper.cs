using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Models;
using HtmlAgilityPack;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;

namespace Audio_Master
{
    public class Scraper
    {
        frmMain main;
        List<string> webSongs = new List<string>();
        List<string> webLyrics = new List<string>();
        List<string> webTimes = new List<string>();
        public static HtmlWeb web = new HtmlWeb();
        public static HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        private readonly YoutubeClient client = new YoutubeClient();
        Dictionary<string, string> _lyrics = new Dictionary<string, string>();

        public Scraper(frmMain m)
        {
            main = m;
            timer.Tick += Timer_Tick;
        }

        public void ScrapeWiki(string url)
        {
            document = web.Load(url);

            HtmlNode node = document.DocumentNode.SelectNodes("//*[@class='image']")[0];
            string imageUrl = node.OuterHtml.Remove(0, node.OuterHtml.IndexOf("upload.wikimedia"));
            imageUrl = "https://" + imageUrl.Remove(imageUrl.IndexOf("\""));
            GetImage(imageUrl);

            node = document.DocumentNode.SelectNodes("//*[@class='contributor']")[0];
            main.txtArtist.Text = node.InnerText;

            node = document.DocumentNode.SelectNodes("//*[@class='summary album']")[0];
            main.txtAlbum.Text = node.InnerHtml;

            node = document.DocumentNode.SelectNodes("//*[@class='published']")[0];
            main.txtYear.Text = node.InnerText.Remove(0, node.InnerText.Length - 4);
        }

        public void ScrapeArchives()
        {
            if (main.browser.Document == null)
                return;

            // open lyrics
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("a"))
                if (el.Id != null && el.Id.Contains("lyricsButton"))
                    el.InvokeMember("onclick");

            // get artist
            if (main.txtArtist.Text == "")
                foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("h2"))
                    main.txtArtist.Text = el.InnerText;

            // get album name
            if (main.txtAlbum.Text == "")
                foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("h1"))
                    main.txtAlbum.Text = el.InnerText;

            // get year
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("dd"))
                if (el.InnerHtml != null && el.OuterHtml.Contains(", ") || el.OuterHtml.Contains("19") || el.OuterHtml.Contains("20"))
                {
                    main.txtYear.Text = el.InnerHtml.Remove(0, el.InnerHtml.Length - 5).TrimEnd(' ');
                    break;
                }

            // get type
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("dd"))
                if (el.InnerHtml.Contains("EP"))
                {
                    main.txtAlbum.Text = main.txtAlbum.Text + " (EP)";
                    break;
                }                  

            // get songs
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("td"))
                if (el.OuterHtml.Contains("wrapWords"))
                    webSongs.Add(el.InnerHtml.Remove(el.InnerHtml.Length - 1).Replace("&amp;", "&"));

            // get web times
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("td"))
                if (el.InnerHtml != null && el.OuterHtml.Contains("<TD align=right>"))
                    webTimes.Add(el.InnerHtml);
                else if (webTimes.Count == webSongs.Count)
                    break;

            // get image
            string html = "";
            foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("a"))
                if (el.OuterHtml.Contains("id=cover"))
                    html = el.OuterHtml;

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
            timer.Start(); // scrape lyrics
        }
   
        public void GetImage(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 50000;
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            Image i = Image.FromStream(stream);
            main.pbCoverArt.Image = i;
            webResponse.Close();
        }

        public Timer timer = new Timer();
        public int ticks = 0;
        public void Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 30) // delay 3 seconds to ensure that lyrics have loaded (might be too short for larger albums)
            {
                timer.Stop();
                ticks = 0;

                // get lyrics
                foreach (HtmlElement el in main.browser.Document.GetElementsByTagName("td"))
                {
                    if (el.Id != null && el.Id.Contains("lyrics_"))
                    {
                        if (el.InnerText.ToString() != "(loading lyrics...)")
                            webLyrics.Add(el.InnerText.ToString().Remove(0, 1));
                        else if (el.InnerText.ToString().ToLower().Contains("instrumental"))
                            webLyrics.Add("Instrumental");
                        else
                            webLyrics.Add("NA");
                    }
                }
                            
                if (webLyrics.Count != webSongs.Count)
                {
                    MessageBox.Show("error");
                    return;
                }

                foreach (string s in webSongs)
                {
                    if (!main._lyrics.ContainsKey(s))
                        main._lyrics.Add(s, webLyrics[webSongs.IndexOf(s)]);
                }

                main.btnAdd.Enabled = true;
                webSongs = new List<string>();
                webLyrics = new List<string>();
                webTimes = new List<string>();
            }
        }
    }
}
