using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models;
using YoutubeExplode.Models.MediaStreams;
using System.Drawing;
using System.Linq;
using iTunesLib;

namespace Audio_Master
{
    public static class ToolTipController
    {
        public static void Show(ToolTip toolTip, object o, MenuStrip menuStrip)
        {
            string type = o.GetType().Name;
            string text = String.Empty;

            if (type == "Button")
            {
                toolTip.Show("button", (o as Button));
            }
            else if (type == "PictureBox")
            {
                toolTip.Show("pic", (o as PictureBox));
            }
            else if (type == "ToolStripMenuItem")
            {            
                toolTip.Show("tsmi", menuStrip);
            }          
            else
            {

            }
        }
    }
}
