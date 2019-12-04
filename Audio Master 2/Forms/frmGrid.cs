using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Audio_Master
{
    public partial class frmGrid : Form
    {
        public List<Album> Albums = new List<Album>();

        public frmGrid()
        {
            InitializeComponent();

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
                dgvMain.Rows.Add(a.Artist, a.Name, a.songs.Count, a.NullCount.ToString(), a.NACount.ToString());

                if (a.NullCount > 0)
                    dgvMain.Rows[dgvMain.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
    }
}