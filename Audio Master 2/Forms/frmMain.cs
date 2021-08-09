using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models;

namespace Audio_Master
{
    public partial class frmMain : Form
    {
        enum Status
        {
            New,
            Queued,
            Downloading,
            Downloaded
        }

        public List<Song> Songs = new List<Song>();
        private Downloader _downloader = new Downloader();
        private Scraper _scraper;
        //private string _pasted = "";
        private int _selectedRow = -1;
        private bool _downloading = false;
        private List<Color> _colors = new List<Color>();
        private Dictionary<string, string> _startingTimes = new Dictionary<string, string>();
        public Dictionary<string, string> Lyrics = new Dictionary<string, string>();
        public bool Loaded = false;

        private readonly YoutubeClient client = new YoutubeClient();

        public frmMain()
        {
            InitializeComponent();

            #region DropDownEvents

            tsmiSettings.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            tsmiColumns.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            tsmiHeaderFields.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            tsmiColors.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);

            #endregion

            //gridUtils = new GridUtils(dataGrid);

            //gridUtils.Test(dataGrid);
            //dataGrid = null;

            Settings.LoadForm(tsmiSettings, this, "Settings_Main");
            Settings.LoadColumns(dataGrid, tsmiColumns);
            Settings.LoadList(tscbGenre, "Genre");
            Settings.LoadList(tscbGrouping, "Grouping");
            LoadColors();
            RefreshHeaders();
            _scraper = new Scraper(this);
            Loaded = true;

            #region tests

            #endregion
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SaveForm(tsmiSettings, Width, Height, WindowState);
            Settings.SaveColumns(dataGrid);
            Settings.SaveList(tscbGenre, "Genre");
            Settings.SaveList(tscbGrouping, "Grouping");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        #region Settings

        private void Column_Checked(object sender, EventArgs e)
        {
            if (!Loaded)
                return;
            ToolStripMenuItem tsmi = (sender as ToolStripMenuItem);
            string col = "c" + tsmi.Name.Replace("tsmiCol", "");
            dataGrid.Columns[col].Visible = tsmi.Checked;
        }

        private void Header_Checked(object sender, EventArgs e)
        {
            if (!Loaded)
                return;
            RefreshHeaders();
        }

        private void RefreshHeaders()
        {
            int count = 0;
            count = RefreshHeader(txtArtist, lblArtist, tsmiHeaderArtist.Checked, count);
            count = RefreshHeader(txtComposer, lblComposer, tsmiHeaderComposer.Checked, count);
            count = RefreshHeader(txtAlbum, lblAlbum, tsmiHeaderAlbum.Checked, count);
            count = RefreshHeader(txtYear, lblYear, tsmiHeaderYear.Checked, count);
            count = RefreshHeader(txtGenre, lblGenre, tsmiHeaderGenre.Checked, count);
            count = RefreshHeader(txtGrouping, lblGrouping, tsmiHeaderGrouping.Checked, count);
            btnClear.Visible = count != 0;
            pbCoverArt.Size = count == 0 ? new Size(147, 147) : new Size(count * 25 - 5, count * 25 - 5);
            pbCoverArt.Visible = tsmiHeaderImage.Checked;
        }

        private int RefreshHeader(Control c, Label lbl, bool show, int count)
        {
            c.Visible = lbl.Visible = show;
            c.Location = new Point(74, 31 + count * 25);
            lbl.Location = new Point(14, 31 + count * 25);
            if (!show)
            {
                c.Text = String.Empty;
                return count;
            }
            c.Width = count == 0 ? 356 : 378;
            return count + 1;
        }

        private void Setting_Checked(object sender, EventArgs e)
        {
            if (!Loaded)
                return;

            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            string name = tsmi.Name.Replace("tsmi", "");

            if (name.Equals("EditOnEnter"))
            {
                dataGrid.EditMode = tsmi.Checked ? DataGridViewEditMode.EditOnEnter : DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
            else if (name.Equals("ShowTooltips"))
            {
               
            }
            Settings.SaveValue(tsmi.Name, tsmi.Checked.ToString());
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void LoadColors()
        {
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                Color c = Color.FromKnownColor(color);
                if (c.Name == "Transparent")
                    continue;
                _colors.Add(c);
                tscbColors.Items.Add(c.ToString().TrimEnd(']').Replace("Color [", ""));
            }
            tscbColors.SelectedItem = tsmiColorStatusNew.BackColor.Name;
            BackColor = Settings.LoadColor("tsmiColorBackground");
            dataGrid.BackgroundColor = Settings.LoadColor("tsmiColorGridBackground");
        }

        private void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            //AppFocusChange CloseCalled AppClicked
            if (e.CloseReason.ToString() == "ItemClicked")
                e.Cancel = true;
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            tsmiColorBackground.Checked = tsmiColorGridBackground.Checked = tsmiColorStatusNew.Checked = 
            tsmiColorStatusQueued.Checked = tsmiColorStatusDownloading.Checked = tsmiColorStatusDownloaded.Checked = false;
            ToolStripMenuItem tsmi = (sender as ToolStripMenuItem);
            tsmi.Checked = true;
            tscbColors.SelectedItem = tsmi.BackColor.Name;
        }

        private void tscbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tsmi = (sender as ToolStripMenuItem);
            Color color = _colors.Where(c => c.Name == tscbColors.SelectedItem.ToString()).ToList()[0];

            if (tsmiColorBackground.Checked)
                tsmiColorBackground.BackColor = this.BackColor = color;

            else if (tsmiColorGridBackground.Checked)
                tsmiColorGridBackground.BackColor = dataGrid.BackgroundColor = color;

            else if (tsmiColorStatusNew.Checked)
                UpdateRowColor(tsmiColorStatusNew, color);

            else if (tsmiColorStatusQueued.Checked)
                UpdateRowColor(tsmiColorStatusQueued, color);

            else if (tsmiColorStatusDownloading.Checked)
                UpdateRowColor(tsmiColorStatusDownloading, color);

            else if (tsmiColorStatusDownloaded.Checked)
                UpdateRowColor(tsmiColorStatusDownloaded, color);
        }

        private void UpdateRowColor(ToolStripMenuItem tsmi, Color next)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.DefaultCellStyle.BackColor == tsmi.BackColor)
                    row.DefaultCellStyle.BackColor = next;
            }
            tsmi.BackColor = next;
        }

        private void UpdateStatusColors(string status, Color color)
        {
            foreach (Song s in Songs)
                dataGrid.Rows[s.RowIndex].DefaultCellStyle.BackColor = color;
        }

        #endregion

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _scraper.ScrapeArchives();
        }

        private void pbCoverArt_Click(object sender, EventArgs e)
        {
            Image i = Clipboard.GetImage();
            if (i != null)
                pbCoverArt.Image = i;
        }

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Focus();
            string text = Clipboard.GetText();

            if (text.Contains("youtube"))
            {
                AddYoutubeVideo(text);
            }
            else if (text.Contains("wikipedia"))
            {
                _scraper.ScrapeWiki(text);
            }
            else if (text.Contains("metal-archives"))
            {
                browser.Navigate(text);
                btnAdd.Enabled = false;
            }
        }

        public async void AddYoutubeVideo(string url)
        {
            try
            {
                string id = url.Replace("https://www.youtube.com/watch?v=", "");
                if (id.Contains("&t="))
                    id = id.Remove(id.IndexOf("&t="));
                if (id.Contains("&start_radio="))
                    id = id.Remove(id.IndexOf("&start_radio="));

                if (!id.Contains("&list="))
                {
                    Video video = await client.GetVideoAsync(id);
                    AddSong(video);
                }
                else
                {
                    id = id.Remove(0, id.IndexOf("&list=") + 6);
                    if (id.Contains("&index="))
                        id = id.Remove(id.IndexOf("&index="));
                    Playlist playlist = await client.GetPlaylistAsync(id);
                    int i = 1;
                    foreach (Video v in playlist.Videos)
                        AddSong(v, i++);
                    ClearHeader();
                }
                AddLyrics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AddSong(Video v, int trackNum = 0)
        {
            string title = v.Title;
            string artist = txtArtist.Text;

            if (title != artist && (title.StartsWith(artist) || title.StartsWith(artist.ToLower()) || title.StartsWith(artist.ToUpper())))
                title = title.Remove(0, artist.Length).TrimStart().TrimStart('-').TrimStart();

            Song s = new Song()
            {
                TrackNumber = trackNum == 0 ? 0 : trackNum,
                Name = title,
                Artist = artist,
                Composer = txtComposer.Text,
                Album = txtAlbum.Text,
                Year = txtYear.Text,
                Genre = txtGenre.Text,
                Grouping = txtGrouping.Text,
                Image = pbCoverArt.Image,
                ID = v.Id,
                Video = v,
                Time = v.Duration,
                RowIndex = dataGrid.Rows.Count
            };

            if (Songs.Where(o => o.Name == s.Name && o.Album == s.Album).ToList().Count != 0)
                return;

            Songs.Add(s);

            if (trackNum == 0)
                dataGrid.Rows.Add(null, s.Name, s.Artist, s.Album, s.Year, s.Grouping, s.Genre, s.Time, s.Lyrics, s.ID, s.StartTime, s.Composer, "", s.Image, s.DiscNumber);
            else
                dataGrid.Rows.Add(trackNum, s.Name, s.Artist, s.Album, s.Year, s.Grouping, s.Genre, s.Time, s.Lyrics, s.ID, s.StartTime, s.Composer, "", s.Image, s.DiscNumber);

            SetStatus(s, "New", tsmiColorStatusNew.BackColor);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async void DownloadSongs()
        {
            var songsToQueue = Songs.Where(s => s.Status == "New").ToList();
            if (songsToQueue.Count == 0)
                return;

            foreach (Song s in songsToQueue)
                SetStatus(s, "Queued", tsmiColorStatusQueued.BackColor);

            if (_downloading)
                return;

            _downloading = true;
            while (Songs.Where(s => s.Status == "Queued").ToList().Count > 0) // download all songs in queue
            {
                Song s = Songs.OrderBy(_s => _s.RowIndex).Where(_s => _s.Status == "Queued").ToList()[0];

                if (Songs.Where(_s => _s.ID == s.ID).ToList().Count > 1)
                {
                    foreach (Song _s in Songs.Where(_s => _s.ID == s.ID))
                        SetStatus(_s, "Downloading", tsmiColorStatusDownloading.BackColor);

                    await _downloader.Download(null, Songs.Where(_s => _s.ID == s.ID).ToList());

                    foreach (Song _s in Songs.Where(_s => _s.ID == s.ID))
                        SetStatus(_s, "Downloaded", tsmiColorStatusDownloaded.BackColor);
                }
                else
                {
                    SetStatus(s, "Downloading", tsmiColorStatusDownloading.BackColor);
                    await _downloader.Download(s);
                    SetStatus(s, "Downloaded", tsmiColorStatusDownloaded.BackColor);
                }
            }
            _downloading = false;
            DownloadSongs();
        }

        public void SetStatus(Song s, string status, Color c)
        {
            s.Status = status;
            dataGrid.Rows[s.RowIndex].DefaultCellStyle.BackColor = c;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearHeader();
        }

        private void ClearHeader()
        {
            txtArtist.Text = txtAlbum.Text = txtYear.Text = txtGrouping.Text = txtGenre.Text = String.Empty;
            pbCoverArt.Image = null;
        }

        #endregion

        #region dataGrid Events

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = dataGrid.Rows[e.RowIndex];

            if (e.ColumnIndex == 8)
            {
                string lyrics = Clipboard.GetText();
                dataGrid.Rows[e.RowIndex].Cells[8].ToolTipText = lyrics;
                dataGrid.Rows[e.RowIndex].Cells[8].Value = !String.IsNullOrEmpty(lyrics);
                Songs[e.RowIndex].Lyrics = lyrics;
            }
        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows.Count == 0)
                return;

            DataGridViewRow row = dataGrid.Rows[e.RowIndex];
            int col = e.ColumnIndex;
            string val = row.Cells[col].Value.ToString();

            if (col == 0)
                Songs[row.Index].TrackNumber = Convert.ToInt32(val);
            else if (col == 1)
                Songs[row.Index].Name = val;
            else if (col == 2)
                Songs[row.Index].Artist = val;
            else if (col == 3)
                Songs[row.Index].Album = val;
            else if (col == 4)
                Songs[row.Index].Year = val;
            else if (col == 5)
                Songs[row.Index].Grouping = val;
            else if (col == 6)
                Songs[row.Index].Genre = val;
        }

        private void dataGrid_RowCountChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (Song s in Songs.Where(_s => _s.Name == row.Cells["cName"].Value.ToString()))
                    s.RowIndex = row.Index;
            }
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            _startingTimes = StringParser.GetTrackTimes(Clipboard.GetText());
            _selectedRow = dataGrid.HitTest(e.X, e.Y).RowIndex;
            if (_selectedRow == -1)
                return;
            dataGrid.Rows[_selectedRow].Selected = true;
            ContextMenu cm = new ContextMenu();
            AddMenuItem(cm, "Remove");
            AddMenuItem(cm, "Edit");
            if (dataGrid.SelectedRows.Count == 1)
            {
                AddMenuItem(cm, "Split");
                if (_startingTimes.Count == 0 || Songs[_selectedRow].StartTime != null)
                    cm.MenuItems[2].Enabled = false;

                // disable if row is single song
            }
            cm.Show(dataGrid, new Point(e.X, e.Y));
        }

        #region Right Click Menu Item

        public void AddMenuItem(ContextMenu cm, string text)
        {
            MenuItem item = new MenuItem(text);
            item.Click += menuItemClicked;
            cm.MenuItems.Add(item);
        }

        private void DeleteSelectedSongs()
        {
            foreach (int i in GetSelectedRows())
            {
                dataGrid.Rows.RemoveAt(i);
                Songs.RemoveAt(i);
            }
        }

        private void menuItemClicked(object sender, EventArgs e)
        {
            string text = (sender as MenuItem).Text;
            if (text == "Remove" && dataGrid.SelectedRows.Count > 0)
            {
                DeleteSelectedSongs();
            }
            else if (text == "Split")
            {
                SplitSong();
            }
            else if (text == "Edit")
            {
                frmEdit frm = new frmEdit(this);
                if (Application.OpenForms[frm.Name] == null)
                    frm.Show();
                else
                    Application.OpenForms[frm.Name].Activate();
            }
        }

        private void SplitSong()
        {
            DataGridViewRow row = dataGrid.SelectedRows[0];
            string id = row.Cells["cID"].Value.ToString();
            Song album = Songs[row.Index];
            int albumSeconds = album.Time.Seconds;

            int i = 1;
            foreach (KeyValuePair<string, string> pair in _startingTimes)
            {
                Song s = new Song()
                {
                    TrackNumber = i++,
                    Name = pair.Key,
                    Artist = row.Cells["cArtist"].Value.ToString(),
                    Album = row.Cells["cAlbum"].Value.ToString(),
                    Year = row.Cells["cYear"].Value.ToString(),
                    Grouping = row.Cells["cGrouping"].Value.ToString(),
                    Genre = row.Cells["cGenre"].Value.ToString(),
                    Image = album.Image,
                    ID = id,
                    Video = album.Video,
                    RowIndex = dataGrid.Rows.Count,
                    StartTime = pair.Value
                };
                s.StartSeconds = Convert.ToInt32(s.StartTime.Split(':')[1]) + Convert.ToInt32(s.StartTime.Split(':')[0]) * 60;
                Songs.Add(s);
                dataGrid.Rows.Add(s.TrackNumber, s.Name, s.Artist, s.Album, s.Year, s.Grouping, s.Genre, s.Time, s.Lyrics, s.ID, s.StartTime); 
            }

            Songs.RemoveAt(row.Index);
            dataGrid.Rows.RemoveAt(row.Index);

            SetStartingTimes(id, album.Time.TotalSeconds);

            AddLyrics();
        }

        private void SetStartingTimes(string id, double totalSeconds)
        {
            foreach (Song s in Songs.Where(_s => _s.ID == id))
            {
                int seconds;
                if (Songs.IndexOf(s) != Songs.Count - 1)
                    seconds = Songs[Songs.IndexOf(s) + 1].StartSeconds - s.StartSeconds;
                else
                    seconds = Convert.ToInt32(totalSeconds) - s.StartSeconds;
                int minutes = seconds / 60;
                seconds = seconds - minutes * 60;
                s.Time = new TimeSpan(0, minutes, seconds);
                SetStatus(s, "New", tsmiColorStatusNew.BackColor);
            }
        }

        public List<int> GetSelectedRows()
        {
            var list = new List<int>();
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
                list.Add(row.Index);
            return list.OrderByDescending(i => i).ToList();
        }

        #endregion

        #endregion

        public void UpdateTimeLabel()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[2].Value == null)
                    return;
                string[] times = row.Cells[2].Value.ToString().Split(':');
                int minutes = Convert.ToInt32(times[0]) * 60;
                minutes = minutes + Convert.ToInt32(times[1]);
                total = total + minutes;
            }
            int mins = total / 60;
            int secs = total - mins * 60;
            lblTotalTime.Text = Convert.ToString(mins + ":" + secs);
        }

        public void AddLyrics()
        {
            foreach (KeyValuePair<string, string> pair in Lyrics)
            {
                foreach (Song s in Songs.Where(_s => _s.Name.ToLower() == pair.Key.ToLower()))
                {
                    s.Lyrics = pair.Value;
                    dataGrid.Rows[s.RowIndex].Cells["cLyrics"].ToolTipText = pair.Value;
                    dataGrid.Rows[s.RowIndex].Cells["cLyrics"].Value = true;
                }
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //var v = new InterceptKeys();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            if (tsmiShowTooltips.Checked)
                ToolTipController.Show(toolTip, sender, menuStrip);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmiClean_Click(object sender, EventArgs e)
        {
            AlbumCleaner.Clean();      
        }
    }
}
