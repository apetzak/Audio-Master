namespace Audio_Master
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.txtGrouping = new System.Windows.Forms.ComboBox();
            this.pbCoverArt = new System.Windows.Forms.PictureBox();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGrouping = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblComposer = new System.Windows.Forms.Label();
            this.lblDiscNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.tsmiAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComposer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiscNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYear = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGrouping
            // 
            this.txtGrouping.FormattingEnabled = true;
            this.txtGrouping.Items.AddRange(new object[] {
            "Australia",
            "Austria",
            "Belgium",
            "Brazil",
            "Can",
            "Czech",
            "Den",
            "Fin",
            "France",
            "Ger",
            "Italy",
            "Jap",
            "Nether",
            "Norway",
            "Pol",
            "Russia",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Swiss",
            "Turkey",
            "UK",
            "US"});
            this.txtGrouping.Location = new System.Drawing.Point(71, 259);
            this.txtGrouping.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrouping.Name = "txtGrouping";
            this.txtGrouping.Size = new System.Drawing.Size(189, 21);
            this.txtGrouping.TabIndex = 30;
            // 
            // pbCoverArt
            // 
            this.pbCoverArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCoverArt.Location = new System.Drawing.Point(11, 32);
            this.pbCoverArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbCoverArt.Name = "pbCoverArt";
            this.pbCoverArt.Size = new System.Drawing.Size(121, 121);
            this.pbCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoverArt.TabIndex = 36;
            this.pbCoverArt.TabStop = false;
            this.pbCoverArt.Click += new System.EventHandler(this.pbCoverArt_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.FormattingEnabled = true;
            this.txtGenre.Items.AddRange(new object[] {
            "Alternative Metal",
            "Black Metal",
            "Death Metal",
            "Death/Progressive Metal",
            "Doom Metal",
            "Epic Doom Metal",
            "Folk Metal",
            "Funk Metal",
            "Heavy Metal",
            "Neoclassical Metal",
            "NWOBHM",
            "Power Metal",
            "Progressive Metal",
            "Progressive Rock",
            "Soundtrack",
            "Speed Metal",
            "Thrash Metal",
            "Thrash/Black Metal",
            "Thrash/Crossover Metal",
            "Thrash/Death Metal",
            "Thrash/Heavy Metal",
            "Thrash/Power Metal",
            "Thrash/Progressive Metal",
            "Thrash/Speed Metal",
            "Viking Metal"});
            this.txtGenre.Location = new System.Drawing.Point(71, 233);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(189, 21);
            this.txtGenre.TabIndex = 32;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(11, 234);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(56, 18);
            this.lblGenre.TabIndex = 35;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrouping
            // 
            this.lblGrouping.AutoSize = true;
            this.lblGrouping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrouping.Location = new System.Drawing.Point(11, 260);
            this.lblGrouping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrouping.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblGrouping.Name = "lblGrouping";
            this.lblGrouping.Size = new System.Drawing.Size(56, 18);
            this.lblGrouping.TabIndex = 34;
            this.lblGrouping.Text = "Grouping";
            this.lblGrouping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(11, 210);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 18);
            this.lblYear.TabIndex = 33;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(71, 209);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(189, 20);
            this.txtYear.TabIndex = 29;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(11, 185);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(56, 18);
            this.lblAlbum.TabIndex = 31;
            this.lblAlbum.Text = "Album";
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(71, 184);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(189, 20);
            this.txtAlbum.TabIndex = 27;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(11, 160);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(56, 18);
            this.lblArtist.TabIndex = 28;
            this.lblArtist.Text = "Artist";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(71, 159);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(189, 20);
            this.txtArtist.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(125, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 25);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(11, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 25);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComposer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposer.Location = new System.Drawing.Point(11, 285);
            this.lblComposer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComposer.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(56, 18);
            this.lblComposer.TabIndex = 40;
            this.lblComposer.Text = "Composer";
            this.lblComposer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscNumber
            // 
            this.lblDiscNumber.AutoSize = true;
            this.lblDiscNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscNumber.Location = new System.Drawing.Point(152, 129);
            this.lblDiscNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscNumber.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblDiscNumber.Name = "lblDiscNumber";
            this.lblDiscNumber.Size = new System.Drawing.Size(56, 18);
            this.lblDiscNumber.TabIndex = 41;
            this.lblDiscNumber.Text = "Disc #";
            this.lblDiscNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 128);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 43;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(71, 284);
            this.txtComposer.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(189, 20);
            this.txtComposer.TabIndex = 44;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiColumns});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(522, 24);
            this.menuStrip.TabIndex = 45;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiColumns
            // 
            this.tsmiColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlbum,
            this.tsmiArtist,
            this.tsmiComposer,
            this.tsmiDiscNumber,
            this.tsmiGenre,
            this.tsmiGrouping,
            this.tsmiImage,
            this.tsmiLyrics,
            this.tsmiYear});
            this.tsmiColumns.Name = "tsmiColumns";
            this.tsmiColumns.Size = new System.Drawing.Size(67, 20);
            this.tsmiColumns.Text = "Columns";
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rtbLyrics.Location = new System.Drawing.Point(271, 53);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(241, 310);
            this.rtbLyrics.TabIndex = 46;
            this.rtbLyrics.Text = "";
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyrics.Location = new System.Drawing.Point(271, 32);
            this.lblLyrics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLyrics.MinimumSize = new System.Drawing.Size(56, 18);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(56, 18);
            this.lblLyrics.TabIndex = 47;
            this.lblLyrics.Text = "Lyrics";
            this.lblLyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsmiAlbum
            // 
            this.tsmiAlbum.Checked = true;
            this.tsmiAlbum.CheckOnClick = true;
            this.tsmiAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAlbum.Name = "tsmiAlbum";
            this.tsmiAlbum.Size = new System.Drawing.Size(180, 22);
            this.tsmiAlbum.Text = "Album";
            // 
            // tsmiArtist
            // 
            this.tsmiArtist.Checked = true;
            this.tsmiArtist.CheckOnClick = true;
            this.tsmiArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiArtist.Name = "tsmiArtist";
            this.tsmiArtist.Size = new System.Drawing.Size(180, 22);
            this.tsmiArtist.Text = "Artist";
            // 
            // tsmiComposer
            // 
            this.tsmiComposer.Checked = true;
            this.tsmiComposer.CheckOnClick = true;
            this.tsmiComposer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiComposer.Name = "tsmiComposer";
            this.tsmiComposer.Size = new System.Drawing.Size(180, 22);
            this.tsmiComposer.Text = "Composer";
            // 
            // tsmiDiscNumber
            // 
            this.tsmiDiscNumber.Checked = true;
            this.tsmiDiscNumber.CheckOnClick = true;
            this.tsmiDiscNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiDiscNumber.Name = "tsmiDiscNumber";
            this.tsmiDiscNumber.Size = new System.Drawing.Size(180, 22);
            this.tsmiDiscNumber.Text = "Disc Number";
            // 
            // tsmiGenre
            // 
            this.tsmiGenre.Checked = true;
            this.tsmiGenre.CheckOnClick = true;
            this.tsmiGenre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiGenre.Name = "tsmiGenre";
            this.tsmiGenre.Size = new System.Drawing.Size(180, 22);
            this.tsmiGenre.Text = "Genre";
            // 
            // tsmiGrouping
            // 
            this.tsmiGrouping.Checked = true;
            this.tsmiGrouping.CheckOnClick = true;
            this.tsmiGrouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiGrouping.Name = "tsmiGrouping";
            this.tsmiGrouping.Size = new System.Drawing.Size(180, 22);
            this.tsmiGrouping.Text = "Grouping";
            // 
            // tsmiImage
            // 
            this.tsmiImage.Checked = true;
            this.tsmiImage.CheckOnClick = true;
            this.tsmiImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiImage.Name = "tsmiImage";
            this.tsmiImage.Size = new System.Drawing.Size(180, 22);
            this.tsmiImage.Text = "Image";
            // 
            // tsmiLyrics
            // 
            this.tsmiLyrics.Checked = true;
            this.tsmiLyrics.CheckOnClick = true;
            this.tsmiLyrics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLyrics.Name = "tsmiLyrics";
            this.tsmiLyrics.Size = new System.Drawing.Size(180, 22);
            this.tsmiLyrics.Text = "Lyrics";
            // 
            // tsmiYear
            // 
            this.tsmiYear.Checked = true;
            this.tsmiYear.CheckOnClick = true;
            this.tsmiYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiYear.Name = "tsmiYear";
            this.tsmiYear.Size = new System.Drawing.Size(180, 22);
            this.tsmiYear.Text = "Year";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(522, 375);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.rtbLyrics);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDiscNumber);
            this.Controls.Add(this.lblComposer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtGrouping);
            this.Controls.Add(this.pbCoverArt);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblGrouping);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(538, 1000);
            this.MinimumSize = new System.Drawing.Size(538, 414);
            this.Name = "frmEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtGrouping;
        public System.Windows.Forms.PictureBox pbCoverArt;
        private System.Windows.Forms.ComboBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblGrouping;
        private System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAlbum;
        public System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblArtist;
        public System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblComposer;
        private System.Windows.Forms.Label lblDiscNumber;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiColumns;
        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlbum;
        private System.Windows.Forms.ToolStripMenuItem tsmiArtist;
        private System.Windows.Forms.ToolStripMenuItem tsmiComposer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiscNumber;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenre;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrouping;
        private System.Windows.Forms.ToolStripMenuItem tsmiImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiLyrics;
        private System.Windows.Forms.ToolStripMenuItem tsmiYear;
    }
}