using System;
using System.Drawing;
using System.Windows.Forms;

namespace Audio_Master
{
    public partial class frmEdit : Form
    {
        frmMain _frmMain;

        public frmEdit(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            SetFieldValues();
            Settings.LoadForm(tsmiColumns, this, "Settings_Edit");
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SaveForm(tsmiColumns, Width, Height, WindowState, "Settings_Edit");
        }

        public void SetFieldValues()
        {
            Song s = _frmMain.Songs[_frmMain.GetSelectedRows()[0]];
            int selected = _frmMain.GetSelectedRows().Count;
            if (_frmMain.GetSelectedRows().Count == 1)
            {
                rtbLyrics.Text = s.Lyrics;
            }
            else
            {
                rtbLyrics.Visible = lblLyrics.Visible = false;
                MinimumSize = new Size(Width - rtbLyrics.Width, 414);
                MaximumSize = new Size(Width - rtbLyrics.Width, 1000);
                Width = Width - rtbLyrics.Width;
            }

            bool sameArtist = true;
            bool sameAlbum = true;
            bool sameYear = true;
            bool sameGrouping = true;
            bool sameGenre = true;
            bool sameImage = true;
            bool sameComposer = true;
            bool sameDiscNumber = true;

            foreach (int i in _frmMain.GetSelectedRows())
            {
                if (_frmMain.Songs[i].Artist != s.Artist)
                    sameArtist = false;
                if (_frmMain.Songs[i].Album != s.Album)
                    sameAlbum = false;
                if (_frmMain.Songs[i].Year != s.Year)
                    sameYear = false;
                if (_frmMain.Songs[i].Grouping != s.Grouping)
                    sameGrouping = false;
                if (_frmMain.Songs[i].Genre != s.Genre)
                    sameGenre = false;
                if (_frmMain.Songs[i].Image != s.Image)
                    sameImage = false;
                if (_frmMain.Songs[i].Composer != s.Composer)
                    sameComposer = false;
                if (_frmMain.Songs[i].DiscNumber != s.DiscNumber)
                    sameDiscNumber = false;
            }

            if (sameArtist)
                txtArtist.Text = s.Artist;
            if (sameAlbum)
                txtAlbum.Text = s.Album;
            if (sameYear)
                txtYear.Text = s.Year;
            if (sameGrouping)
                txtGrouping.Text = s.Grouping;
            if (sameGenre)
                txtGenre.Text = s.Genre;
            if (sameImage)
                pbCoverArt.Image = s.Image;
            if (sameComposer)
                txtComposer.Text = s.Composer;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            foreach (int i in _frmMain.GetSelectedRows())
            {
                _frmMain.dataGrid.Rows[i].Cells[2].Value = txtArtist.Text;
                _frmMain.dataGrid.Rows[i].Cells[3].Value = txtAlbum.Text;
                _frmMain.dataGrid.Rows[i].Cells[4].Value = txtYear.Text;
                _frmMain.dataGrid.Rows[i].Cells[5].Value = txtGrouping.Text;
                _frmMain.dataGrid.Rows[i].Cells[6].Value = txtGenre.Text;

                _frmMain.Songs[i].Artist = txtArtist.Text;
                _frmMain.Songs[i].Album = txtAlbum.Text;
                _frmMain.Songs[i].Year = txtYear.Text;
                _frmMain.Songs[i].Grouping = txtGrouping.Text;
                _frmMain.Songs[i].Genre = txtGenre.Text;
                _frmMain.Songs[i].Image = pbCoverArt.Image;
                _frmMain.Songs[i].Composer = txtComposer.Text;

                if (!String.IsNullOrEmpty(rtbLyrics.Text))
                {
                    _frmMain.dataGrid.Rows[i].Cells[8].Value = true;
                    _frmMain.dataGrid.Rows[i].Cells[8].ToolTipText = rtbLyrics.Text;
                    _frmMain.Songs[i].Lyrics = rtbLyrics.Text;
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pbCoverArt_Click(object sender, System.EventArgs e)
        {
            Image i = Clipboard.GetImage();
            if (i != null)
                pbCoverArt.Image = i;
        }
    }
}