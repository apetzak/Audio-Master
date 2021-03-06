﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;

namespace Audio_Master
{
    public static class Settings
    {
        public static string GetPath(string file)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), file);
        }

        public static void SaveForm(ToolStripMenuItem tsmiSettings, int width, int height, FormWindowState state, string file = "Settings_Main", bool reset = false)
        {
            var values = new Dictionary<string, string>();
            foreach (ToolStripMenuItem tsmi in tsmiSettings.DropDownItems)
            {
                if (!tsmi.HasDropDownItems)
                {
                    values.Add(tsmi.Name, tsmi.Checked.ToString());
                    continue;
                }

                foreach (object o in tsmi.DropDownItems)
                {
                    Type t = o.GetType();

                    if (t == typeof(ToolStripTextBox))
                        values.Add((o as ToolStripTextBox).Name, (o as ToolStripTextBox).Text);

                    else if (t == typeof(ToolStripComboBox)) { }
                    //defaultValues.Add((o as ToolStripComboBox).Name.Replace("tscb", ""), "");

                    else if (t == typeof(ToolStripMenuItem) && (o as ToolStripMenuItem).Name.Contains("Color"))
                        values.Add((o as ToolStripMenuItem).Name, (o as ToolStripMenuItem).BackColor.Name);

                    else if (t == typeof(ToolStripMenuItem))
                        values.Add((o as ToolStripMenuItem).Name, (o as ToolStripMenuItem).Checked.ToString());
                }
            }
            values.Add("Height", height.ToString());
            values.Add("Width", width.ToString());
            values.Add("WindowState", state.ToString());
            SaveFile(values, GetPath(file));
        }

        public static void LoadForm(ToolStripMenuItem tsmiSettings, Form form, string file)
        {
            var values = LoadFile(file);
            form.Width = Convert.ToInt32(values["Width"]);
            form.Height = Convert.ToInt32(values["Height"]);
            foreach (ToolStripMenuItem tsmi in tsmiSettings.DropDownItems)
            {
                if (!tsmi.HasDropDownItems && tsmi.CheckOnClick)
                {
                    tsmi.Checked = values[tsmi.Name] == "True" ? true : false;
                    continue;
                }
                SetTsmiDropdownValues(tsmi, values);
            }
        }

        private static void SetTsmiDropdownValues(ToolStripMenuItem tsmi, Dictionary<string, string> values)
        {
            foreach (object o in tsmi.DropDownItems)
            {
                Type t = o.GetType();
                if (t == typeof(ToolStripTextBox))
                    (o as ToolStripTextBox).Text = values[(o as ToolStripTextBox).Name];
                else if (t == typeof(ToolStripComboBox))
                    { }
                else if (t == typeof(ToolStripMenuItem) && (o as ToolStripMenuItem).Name.Contains("Color"))
                    (o as ToolStripMenuItem).BackColor = Color.FromName(values[(o as ToolStripMenuItem).Name]);
                else if (t == typeof(ToolStripMenuItem))
                    (o as ToolStripMenuItem).Checked = values[(o as ToolStripMenuItem).Name] == "True" ? true : false;
            }
        }

        public static void SaveColumns(DataGridView dgv)
        {
            var values = new Dictionary<string, string>();
            foreach (DataGridViewColumn col in dgv.Columns)
                values.Add(col.Name, col.Width + ":" + col.DisplayIndex);
            SaveFile(values, "Settings_Columns");
        }

        public static void LoadColumns(DataGridView dgv, ToolStripMenuItem tsmiColumns)
        {
            var values = LoadFile("Settings_Columns");
            foreach (ToolStripMenuItem tsmi in tsmiColumns.DropDownItems)
            {
                string col = "c" + tsmi.Name.Replace("tsmiCol", "");
                dgv.Columns[col].Visible = tsmi.Checked;
                dgv.Columns[col].Width = Convert.ToInt32(values[col].Split(':')[0]);
                dgv.Columns[col].DisplayIndex = Convert.ToInt32(values[col].Split(':')[1]);
            }
        }

        public static void SaveList(ToolStripComboBox tscb, string type)
        {

        }

        public static void LoadList(ToolStripComboBox tscb, string type)
        {

        }

        public static void SaveFile(Dictionary<string, string> values, string path)
        {
            //if (!File.Exists(path))
            //    File.Create(path);
            StreamWriter sw = new StreamWriter(path);
            foreach (KeyValuePair <string, string> pair in values)
                sw.WriteLine(String.Format("{0} {1}", pair.Key, pair.Value));
            sw.Close();
        }

        public static Dictionary<string, string> LoadFile(string file)
        {
            var values = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(GetPath(file)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    values.Add(line.Split(' ')[0], line.Split(' ')[1]);
            }
            return values;
        }

        public static string LoadValue(string setting, string file = "Settings_Main")
        {
            using (StreamReader sr = new StreamReader(GetPath(file)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(setting))
                        return line.Split(' ')[1];
                }
            }
            return String.Empty;
        }

        public static Color LoadColor(string setting, string file = "Settings_Main")
        {
            return Color.FromName(LoadValue(setting, file));
        }

        public static void SaveValue(string setting, string value, string file = "Settings_Main")
        {
            var values = LoadFile(file);
            foreach (KeyValuePair<string, string> pair in values)
            {
                if (pair.Key == setting)
                {
                    values[pair.Key] = value;
                    break;
                }
            }
            SaveFile(values, GetPath(file));
        }

        public static string MusicPath
        {
            get { return LoadValue("tstbMusicPath"); }
            set { SaveValue("tstbMusicPath", value); }
        }

        #region Colors

        //public static Color ColorBackground
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorBackground", "Settings_Main")); }
        //    set { ColorBackground = value; SaveValue("tsmiColorBackground", value.Name, "Settings_Main"); }
        //}

        //public static Color ColorGridBackground
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorGridBackground", "Settings_Main")); }
        //    set { ColorGridBackground = value; SaveValue("tsmiColorGridBackground", value.Name, "Settings_Main"); }
        //}

        //public static Color ColorStatusNew
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorStatusNew", "Settings_Main")); }
        //    set { ColorGridBackground = value; SaveValue("tsmiColorStatusNew", value.Name, "Settings_Main"); }
        //}

        //public static Color ColorStatusQueued
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorStatusQueued", "Settings_Main")); }
        //    set { ColorGridBackground = value; SaveValue("tsmiColorStatusQueued", value.Name, "Settings_Main"); }
        //}

        //public static Color ColorStatusDownloading
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorStatusDownloading", "Settings_Main")); }
        //    set { ColorGridBackground = value; SaveValue("tsmiColorStatusDownloading", value.Name, "Settings_Main"); }
        //}

        //public static Color ColorStatusDownloaded
        //{
        //    get { return Color.FromName(LoadValue("tsmiColorStatusDownloaded", "Settings_Main")); }
        //    set { ColorStatusDownloaded = value; SaveValue("tsmiColorStatusDownloaded", value.Name, "Settings_Main"); }
        //}

        #endregion
    }
}