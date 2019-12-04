namespace Audio_Master
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblGrouping = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cTrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrouping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLyrics = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cComposer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBitrate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.cDiscNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCoverArt = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtGrouping = new System.Windows.Forms.ComboBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMusicPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbMusicPath = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiColors = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbColors = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiColorBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorGridBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorStatusNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorStatusQueued = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorStatusDownloading = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorStatusDownloaded = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColBitrate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColComposer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColDiscNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColTrackNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderFields = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderComposer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbGenre = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiHeaderGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbGrouping = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiHeaderImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHeaderYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBitrate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBitrateMax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBitrateMin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoRemoveDownloaded = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateArtistFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateAlbumFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearSorting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditOnEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowTooltips = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendToiTunes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblComposer = new System.Windows.Forms.Label();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(74, 31);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(356, 20);
            this.txtArtist.TabIndex = 0;
            // 
            // lblArtist
            // 
            this.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(14, 31);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.MinimumSize = new System.Drawing.Size(56, 20);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(56, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlbum
            // 
            this.lblAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(14, 81);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.MinimumSize = new System.Drawing.Size(52, 18);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(56, 20);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Album";
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(74, 81);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(378, 20);
            this.txtAlbum.TabIndex = 1;
            // 
            // lblGrouping
            // 
            this.lblGrouping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrouping.Location = new System.Drawing.Point(14, 155);
            this.lblGrouping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrouping.MinimumSize = new System.Drawing.Size(52, 20);
            this.lblGrouping.Name = "lblGrouping";
            this.lblGrouping.Size = new System.Drawing.Size(56, 20);
            this.lblGrouping.TabIndex = 10;
            this.lblGrouping.Text = "Grouping";
            this.lblGrouping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(14, 106);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.MinimumSize = new System.Drawing.Size(52, 18);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(74, 106);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(378, 20);
            this.txtYear.TabIndex = 2;
            // 
            // lblGenre
            // 
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(14, 130);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.MinimumSize = new System.Drawing.Size(52, 20);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(56, 20);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtGenre.Location = new System.Drawing.Point(74, 131);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(378, 21);
            this.txtGenre.TabIndex = 4;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeight = 36;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTrackNumber,
            this.cName,
            this.cArtist,
            this.cAlbum,
            this.cYear,
            this.cGrouping,
            this.cGenre,
            this.cTime,
            this.cLyrics,
            this.cID,
            this.cStart,
            this.cComposer,
            this.cBitrate,
            this.cImage,
            this.cDiscNumber});
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGrid.Location = new System.Drawing.Point(14, 194);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1077, 582);
            this.dataGrid.TabIndex = 23;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            this.dataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGrid_RowCountChanged);
            this.dataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGrid_RowCountChanged);
            this.dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseClick);
            // 
            // cTrackNumber
            // 
            this.cTrackNumber.HeaderText = "#";
            this.cTrackNumber.Name = "cTrackNumber";
            this.cTrackNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTrackNumber.Width = 35;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.Width = 220;
            // 
            // cArtist
            // 
            this.cArtist.HeaderText = "Artist";
            this.cArtist.Name = "cArtist";
            this.cArtist.Width = 120;
            // 
            // cAlbum
            // 
            this.cAlbum.HeaderText = "Album";
            this.cAlbum.Name = "cAlbum";
            this.cAlbum.Width = 150;
            // 
            // cYear
            // 
            this.cYear.HeaderText = "Year";
            this.cYear.Name = "cYear";
            this.cYear.Width = 50;
            // 
            // cGrouping
            // 
            this.cGrouping.HeaderText = "Grouping";
            this.cGrouping.Name = "cGrouping";
            this.cGrouping.Width = 70;
            // 
            // cGenre
            // 
            this.cGenre.HeaderText = "Genre";
            this.cGenre.Name = "cGenre";
            // 
            // cTime
            // 
            this.cTime.HeaderText = "Time";
            this.cTime.Name = "cTime";
            this.cTime.ReadOnly = true;
            this.cTime.Width = 60;
            // 
            // cLyrics
            // 
            this.cLyrics.HeaderText = "Lyrics";
            this.cLyrics.Name = "cLyrics";
            this.cLyrics.ReadOnly = true;
            this.cLyrics.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cLyrics.Width = 60;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 125;
            // 
            // cStart
            // 
            this.cStart.HeaderText = "Start Time";
            this.cStart.Name = "cStart";
            this.cStart.Width = 60;
            // 
            // cComposer
            // 
            this.cComposer.HeaderText = "Composer";
            this.cComposer.Name = "cComposer";
            this.cComposer.Visible = false;
            // 
            // cBitrate
            // 
            this.cBitrate.HeaderText = "Bitrate";
            this.cBitrate.Name = "cBitrate";
            this.cBitrate.Visible = false;
            // 
            // cImage
            // 
            this.cImage.HeaderText = "Image";
            this.cImage.Name = "cImage";
            this.cImage.Visible = false;
            // 
            // cDiscNumber
            // 
            this.cDiscNumber.HeaderText = "Disc Number";
            this.cDiscNumber.Name = "cDiscNumber";
            this.cDiscNumber.Visible = false;
            // 
            // pbCoverArt
            // 
            this.pbCoverArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCoverArt.Location = new System.Drawing.Point(456, 31);
            this.pbCoverArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbCoverArt.Name = "pbCoverArt";
            this.pbCoverArt.Size = new System.Drawing.Size(147, 147);
            this.pbCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoverArt.TabIndex = 25;
            this.pbCoverArt.TabStop = false;
            this.pbCoverArt.Click += new System.EventHandler(this.pbCoverArt_Click);
            this.pbCoverArt.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(432, 30);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(22, 22);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "X";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(607, 107);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(160, 70);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            this.btnDownload.MouseHover += new System.EventHandler(this.MouseHover);
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
            this.txtGrouping.Location = new System.Drawing.Point(74, 156);
            this.txtGrouping.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrouping.Name = "txtGrouping";
            this.txtGrouping.Size = new System.Drawing.Size(378, 21);
            this.txtGrouping.TabIndex = 3;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(254, 168);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 13);
            this.lblPercentage.TabIndex = 38;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTime.Location = new System.Drawing.Point(772, 110);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTime.MinimumSize = new System.Drawing.Size(30, 24);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(30, 24);
            this.lblTotalTime.TabIndex = 40;
            this.lblTotalTime.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiViewer,
            this.tsmiClean});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip.TabIndex = 42;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMusicPath,
            this.tsmiColors,
            this.tsmiColumns,
            this.tsmiHeaderFields,
            this.tsmiBitrate,
            this.tsmiAutoRemoveDownloaded,
            this.tsmiCreateArtistFolder,
            this.tsmiCreateAlbumFolder,
            this.tsmiClearSorting,
            this.tsmiEditOnEnter,
            this.tsmiShowTooltips,
            this.tsmiSendToiTunes});
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiMusicPath
            // 
            this.tsmiMusicPath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbMusicPath});
            this.tsmiMusicPath.Name = "tsmiMusicPath";
            this.tsmiMusicPath.Size = new System.Drawing.Size(216, 22);
            this.tsmiMusicPath.Text = "Music Path";
            this.tsmiMusicPath.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tstbMusicPath
            // 
            this.tstbMusicPath.Name = "tstbMusicPath";
            this.tstbMusicPath.Size = new System.Drawing.Size(100, 23);
            this.tstbMusicPath.Text = "C:\\";
            // 
            // tsmiColors
            // 
            this.tsmiColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbColors,
            this.tsmiColorBackground,
            this.tsmiColorGridBackground,
            this.tsmiColorStatusNew,
            this.tsmiColorStatusQueued,
            this.tsmiColorStatusDownloading,
            this.tsmiColorStatusDownloaded});
            this.tsmiColors.Name = "tsmiColors";
            this.tsmiColors.Size = new System.Drawing.Size(216, 22);
            this.tsmiColors.Text = "Colors";
            this.tsmiColors.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tscbColors
            // 
            this.tscbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbColors.Name = "tscbColors";
            this.tscbColors.Size = new System.Drawing.Size(121, 23);
            this.tscbColors.SelectedIndexChanged += new System.EventHandler(this.tscbColors_SelectedIndexChanged);
            // 
            // tsmiColorBackground
            // 
            this.tsmiColorBackground.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiColorBackground.Name = "tsmiColorBackground";
            this.tsmiColorBackground.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorBackground.Text = "Background";
            this.tsmiColorBackground.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColorGridBackground
            // 
            this.tsmiColorGridBackground.Name = "tsmiColorGridBackground";
            this.tsmiColorGridBackground.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorGridBackground.Text = "Grid Background";
            this.tsmiColorGridBackground.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColorStatusNew
            // 
            this.tsmiColorStatusNew.Checked = true;
            this.tsmiColorStatusNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColorStatusNew.Name = "tsmiColorStatusNew";
            this.tsmiColorStatusNew.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorStatusNew.Text = "Status New";
            this.tsmiColorStatusNew.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColorStatusQueued
            // 
            this.tsmiColorStatusQueued.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsmiColorStatusQueued.Name = "tsmiColorStatusQueued";
            this.tsmiColorStatusQueued.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorStatusQueued.Text = "Status Queued";
            this.tsmiColorStatusQueued.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColorStatusDownloading
            // 
            this.tsmiColorStatusDownloading.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tsmiColorStatusDownloading.Name = "tsmiColorStatusDownloading";
            this.tsmiColorStatusDownloading.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorStatusDownloading.Text = "Status Downloading";
            this.tsmiColorStatusDownloading.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColorStatusDownloaded
            // 
            this.tsmiColorStatusDownloaded.BackColor = System.Drawing.Color.SpringGreen;
            this.tsmiColorStatusDownloaded.Name = "tsmiColorStatusDownloaded";
            this.tsmiColorStatusDownloaded.Size = new System.Drawing.Size(181, 22);
            this.tsmiColorStatusDownloaded.Text = "Status Downloaded";
            this.tsmiColorStatusDownloaded.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiColumns
            // 
            this.tsmiColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiColAlbum,
            this.tsmiColArtist,
            this.tsmiColBitrate,
            this.tsmiColComposer,
            this.tsmiColDiscNumber,
            this.tsmiColGenre,
            this.tsmiColGrouping,
            this.tsmiColID,
            this.tsmiColImage,
            this.tsmiColLyrics,
            this.tsmiColName,
            this.tsmiColTime,
            this.tsmiColTrackNumber,
            this.tsmiColStart,
            this.tsmiColYear});
            this.tsmiColumns.Name = "tsmiColumns";
            this.tsmiColumns.Size = new System.Drawing.Size(216, 22);
            this.tsmiColumns.Text = "Columns";
            this.tsmiColumns.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiColAlbum
            // 
            this.tsmiColAlbum.Checked = true;
            this.tsmiColAlbum.CheckOnClick = true;
            this.tsmiColAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColAlbum.Name = "tsmiColAlbum";
            this.tsmiColAlbum.Size = new System.Drawing.Size(149, 22);
            this.tsmiColAlbum.Text = "Album";
            this.tsmiColAlbum.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColArtist
            // 
            this.tsmiColArtist.Checked = true;
            this.tsmiColArtist.CheckOnClick = true;
            this.tsmiColArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColArtist.Name = "tsmiColArtist";
            this.tsmiColArtist.Size = new System.Drawing.Size(149, 22);
            this.tsmiColArtist.Text = "Artist";
            this.tsmiColArtist.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColBitrate
            // 
            this.tsmiColBitrate.CheckOnClick = true;
            this.tsmiColBitrate.Name = "tsmiColBitrate";
            this.tsmiColBitrate.Size = new System.Drawing.Size(149, 22);
            this.tsmiColBitrate.Text = "Bit Rate";
            this.tsmiColBitrate.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColComposer
            // 
            this.tsmiColComposer.CheckOnClick = true;
            this.tsmiColComposer.Name = "tsmiColComposer";
            this.tsmiColComposer.Size = new System.Drawing.Size(149, 22);
            this.tsmiColComposer.Text = "Composer";
            this.tsmiColComposer.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColDiscNumber
            // 
            this.tsmiColDiscNumber.CheckOnClick = true;
            this.tsmiColDiscNumber.Name = "tsmiColDiscNumber";
            this.tsmiColDiscNumber.Size = new System.Drawing.Size(149, 22);
            this.tsmiColDiscNumber.Text = "Disc Number";
            this.tsmiColDiscNumber.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColGenre
            // 
            this.tsmiColGenre.Checked = true;
            this.tsmiColGenre.CheckOnClick = true;
            this.tsmiColGenre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColGenre.Name = "tsmiColGenre";
            this.tsmiColGenre.Size = new System.Drawing.Size(149, 22);
            this.tsmiColGenre.Text = "Genre";
            this.tsmiColGenre.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColGrouping
            // 
            this.tsmiColGrouping.Checked = true;
            this.tsmiColGrouping.CheckOnClick = true;
            this.tsmiColGrouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColGrouping.Name = "tsmiColGrouping";
            this.tsmiColGrouping.Size = new System.Drawing.Size(149, 22);
            this.tsmiColGrouping.Text = "Grouping";
            this.tsmiColGrouping.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColID
            // 
            this.tsmiColID.Checked = true;
            this.tsmiColID.CheckOnClick = true;
            this.tsmiColID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColID.Name = "tsmiColID";
            this.tsmiColID.Size = new System.Drawing.Size(149, 22);
            this.tsmiColID.Text = "ID";
            this.tsmiColID.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColImage
            // 
            this.tsmiColImage.CheckOnClick = true;
            this.tsmiColImage.Name = "tsmiColImage";
            this.tsmiColImage.Size = new System.Drawing.Size(149, 22);
            this.tsmiColImage.Text = "Image";
            this.tsmiColImage.CheckStateChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColLyrics
            // 
            this.tsmiColLyrics.Checked = true;
            this.tsmiColLyrics.CheckOnClick = true;
            this.tsmiColLyrics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColLyrics.Name = "tsmiColLyrics";
            this.tsmiColLyrics.Size = new System.Drawing.Size(149, 22);
            this.tsmiColLyrics.Text = "Lyrics";
            this.tsmiColLyrics.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColName
            // 
            this.tsmiColName.Checked = true;
            this.tsmiColName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColName.Name = "tsmiColName";
            this.tsmiColName.Size = new System.Drawing.Size(149, 22);
            this.tsmiColName.Text = "Name";
            this.tsmiColName.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColTime
            // 
            this.tsmiColTime.Checked = true;
            this.tsmiColTime.CheckOnClick = true;
            this.tsmiColTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColTime.Name = "tsmiColTime";
            this.tsmiColTime.Size = new System.Drawing.Size(149, 22);
            this.tsmiColTime.Text = "Time";
            this.tsmiColTime.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColTrackNumber
            // 
            this.tsmiColTrackNumber.Checked = true;
            this.tsmiColTrackNumber.CheckOnClick = true;
            this.tsmiColTrackNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColTrackNumber.Name = "tsmiColTrackNumber";
            this.tsmiColTrackNumber.Size = new System.Drawing.Size(149, 22);
            this.tsmiColTrackNumber.Text = "Track Number";
            this.tsmiColTrackNumber.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColStart
            // 
            this.tsmiColStart.Checked = true;
            this.tsmiColStart.CheckOnClick = true;
            this.tsmiColStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColStart.Name = "tsmiColStart";
            this.tsmiColStart.Size = new System.Drawing.Size(149, 22);
            this.tsmiColStart.Text = "Start";
            this.tsmiColStart.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiColYear
            // 
            this.tsmiColYear.Checked = true;
            this.tsmiColYear.CheckOnClick = true;
            this.tsmiColYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiColYear.Name = "tsmiColYear";
            this.tsmiColYear.Size = new System.Drawing.Size(149, 22);
            this.tsmiColYear.Text = "Year";
            this.tsmiColYear.CheckedChanged += new System.EventHandler(this.Column_Checked);
            // 
            // tsmiHeaderFields
            // 
            this.tsmiHeaderFields.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHeaderAlbum,
            this.tsmiHeaderArtist,
            this.tsmiHeaderComposer,
            this.tsmiHeaderGenre,
            this.tsmiHeaderGrouping,
            this.tsmiHeaderImage,
            this.tsmiHeaderYear});
            this.tsmiHeaderFields.Name = "tsmiHeaderFields";
            this.tsmiHeaderFields.Size = new System.Drawing.Size(216, 22);
            this.tsmiHeaderFields.Text = "Header Fields";
            this.tsmiHeaderFields.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiHeaderAlbum
            // 
            this.tsmiHeaderAlbum.Checked = true;
            this.tsmiHeaderAlbum.CheckOnClick = true;
            this.tsmiHeaderAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderAlbum.Name = "tsmiHeaderAlbum";
            this.tsmiHeaderAlbum.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderAlbum.Text = "Album";
            this.tsmiHeaderAlbum.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tsmiHeaderArtist
            // 
            this.tsmiHeaderArtist.Checked = true;
            this.tsmiHeaderArtist.CheckOnClick = true;
            this.tsmiHeaderArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderArtist.Name = "tsmiHeaderArtist";
            this.tsmiHeaderArtist.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderArtist.Text = "Artist";
            this.tsmiHeaderArtist.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tsmiHeaderComposer
            // 
            this.tsmiHeaderComposer.CheckOnClick = true;
            this.tsmiHeaderComposer.Name = "tsmiHeaderComposer";
            this.tsmiHeaderComposer.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderComposer.Text = "Composer";
            this.tsmiHeaderComposer.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tsmiHeaderGenre
            // 
            this.tsmiHeaderGenre.Checked = true;
            this.tsmiHeaderGenre.CheckOnClick = true;
            this.tsmiHeaderGenre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderGenre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbGenre});
            this.tsmiHeaderGenre.Name = "tsmiHeaderGenre";
            this.tsmiHeaderGenre.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderGenre.Text = "Genre";
            this.tsmiHeaderGenre.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tscbGenre
            // 
            this.tscbGenre.Name = "tscbGenre";
            this.tscbGenre.Size = new System.Drawing.Size(121, 23);
            // 
            // tsmiHeaderGrouping
            // 
            this.tsmiHeaderGrouping.Checked = true;
            this.tsmiHeaderGrouping.CheckOnClick = true;
            this.tsmiHeaderGrouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderGrouping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbGrouping});
            this.tsmiHeaderGrouping.Name = "tsmiHeaderGrouping";
            this.tsmiHeaderGrouping.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderGrouping.Text = "Grouping";
            this.tsmiHeaderGrouping.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tscbGrouping
            // 
            this.tscbGrouping.Name = "tscbGrouping";
            this.tscbGrouping.Size = new System.Drawing.Size(121, 23);
            // 
            // tsmiHeaderImage
            // 
            this.tsmiHeaderImage.Checked = true;
            this.tsmiHeaderImage.CheckOnClick = true;
            this.tsmiHeaderImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderImage.Name = "tsmiHeaderImage";
            this.tsmiHeaderImage.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderImage.Text = "Image";
            this.tsmiHeaderImage.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tsmiHeaderYear
            // 
            this.tsmiHeaderYear.Checked = true;
            this.tsmiHeaderYear.CheckOnClick = true;
            this.tsmiHeaderYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHeaderYear.Name = "tsmiHeaderYear";
            this.tsmiHeaderYear.Size = new System.Drawing.Size(129, 22);
            this.tsmiHeaderYear.Text = "Year";
            this.tsmiHeaderYear.CheckedChanged += new System.EventHandler(this.Header_Checked);
            // 
            // tsmiBitrate
            // 
            this.tsmiBitrate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBitrateMax,
            this.tsmiBitrateMin});
            this.tsmiBitrate.Enabled = false;
            this.tsmiBitrate.Name = "tsmiBitrate";
            this.tsmiBitrate.Size = new System.Drawing.Size(216, 22);
            this.tsmiBitrate.Text = "Bitrate";
            this.tsmiBitrate.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiBitrateMax
            // 
            this.tsmiBitrateMax.Name = "tsmiBitrateMax";
            this.tsmiBitrateMax.Size = new System.Drawing.Size(128, 22);
            this.tsmiBitrateMax.Text = "Maximum";
            // 
            // tsmiBitrateMin
            // 
            this.tsmiBitrateMin.Name = "tsmiBitrateMin";
            this.tsmiBitrateMin.Size = new System.Drawing.Size(128, 22);
            this.tsmiBitrateMin.Text = "Minimum";
            // 
            // tsmiAutoRemoveDownloaded
            // 
            this.tsmiAutoRemoveDownloaded.CheckOnClick = true;
            this.tsmiAutoRemoveDownloaded.Name = "tsmiAutoRemoveDownloaded";
            this.tsmiAutoRemoveDownloaded.Size = new System.Drawing.Size(216, 22);
            this.tsmiAutoRemoveDownloaded.Text = "Auto Remove Downloaded";
            this.tsmiAutoRemoveDownloaded.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            this.tsmiAutoRemoveDownloaded.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiCreateArtistFolder
            // 
            this.tsmiCreateArtistFolder.Checked = true;
            this.tsmiCreateArtistFolder.CheckOnClick = true;
            this.tsmiCreateArtistFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCreateArtistFolder.Name = "tsmiCreateArtistFolder";
            this.tsmiCreateArtistFolder.Size = new System.Drawing.Size(216, 22);
            this.tsmiCreateArtistFolder.Text = "Create Artist Folder";
            this.tsmiCreateArtistFolder.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            this.tsmiCreateArtistFolder.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiCreateAlbumFolder
            // 
            this.tsmiCreateAlbumFolder.Checked = true;
            this.tsmiCreateAlbumFolder.CheckOnClick = true;
            this.tsmiCreateAlbumFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCreateAlbumFolder.Name = "tsmiCreateAlbumFolder";
            this.tsmiCreateAlbumFolder.Size = new System.Drawing.Size(216, 22);
            this.tsmiCreateAlbumFolder.Text = "Create Album Folder";
            this.tsmiCreateAlbumFolder.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            this.tsmiCreateAlbumFolder.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiClearSorting
            // 
            this.tsmiClearSorting.Checked = true;
            this.tsmiClearSorting.CheckOnClick = true;
            this.tsmiClearSorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiClearSorting.Name = "tsmiClearSorting";
            this.tsmiClearSorting.Size = new System.Drawing.Size(216, 22);
            this.tsmiClearSorting.Text = "Clear Sorting";
            this.tsmiClearSorting.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            // 
            // tsmiEditOnEnter
            // 
            this.tsmiEditOnEnter.Checked = true;
            this.tsmiEditOnEnter.CheckOnClick = true;
            this.tsmiEditOnEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiEditOnEnter.Name = "tsmiEditOnEnter";
            this.tsmiEditOnEnter.Size = new System.Drawing.Size(216, 22);
            this.tsmiEditOnEnter.Text = "Edit On Enter";
            this.tsmiEditOnEnter.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            // 
            // tsmiShowTooltips
            // 
            this.tsmiShowTooltips.CheckOnClick = true;
            this.tsmiShowTooltips.Name = "tsmiShowTooltips";
            this.tsmiShowTooltips.Size = new System.Drawing.Size(216, 22);
            this.tsmiShowTooltips.Text = "Show Tooltips";
            this.tsmiShowTooltips.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            this.tsmiShowTooltips.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiSendToiTunes
            // 
            this.tsmiSendToiTunes.Checked = true;
            this.tsmiSendToiTunes.CheckOnClick = true;
            this.tsmiSendToiTunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiSendToiTunes.Name = "tsmiSendToiTunes";
            this.tsmiSendToiTunes.Size = new System.Drawing.Size(216, 22);
            this.tsmiSendToiTunes.Text = "Send to iTunes";
            this.tsmiSendToiTunes.CheckedChanged += new System.EventHandler(this.Setting_Checked);
            this.tsmiSendToiTunes.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // tsmiViewer
            // 
            this.tsmiViewer.Name = "tsmiViewer";
            this.tsmiViewer.Size = new System.Drawing.Size(54, 20);
            this.tsmiViewer.Text = "Viewer";
            // 
            // tsmiClean
            // 
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(49, 20);
            this.tsmiClean.Text = "Clean";
            this.tsmiClean.Click += new System.EventHandler(this.tsmiClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(607, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 70);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(772, 31);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(136, 70);
            this.browser.TabIndex = 44;
            this.browser.Visible = false;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // lblComposer
            // 
            this.lblComposer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComposer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposer.Location = new System.Drawing.Point(14, 56);
            this.lblComposer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComposer.MinimumSize = new System.Drawing.Size(52, 20);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(56, 20);
            this.lblComposer.TabIndex = 46;
            this.lblComposer.Text = "Composer";
            this.lblComposer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(74, 56);
            this.txtComposer.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(378, 20);
            this.txtComposer.TabIndex = 45;
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(914, 31);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.splitter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer.Size = new System.Drawing.Size(176, 147);
            this.splitContainer.SplitterDistance = 78;
            this.splitContainer.TabIndex = 47;
            this.splitContainer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(68, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(10, 147);
            this.splitter.TabIndex = 0;
            this.splitter.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 787);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lblComposer);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtGrouping);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbCoverArt);
            this.Controls.Add(this.dataGrid);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        public System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblGrouping;
        private System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox txtGenre;
        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.PictureBox pbCoverArt;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox txtGrouping;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiColors;
        private System.Windows.Forms.ToolStripComboBox tscbColors;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorStatusNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorStatusQueued;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorStatusDownloading;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorStatusDownloaded;
        private System.Windows.Forms.ToolStripMenuItem tsmiMusicPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendToiTunes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateArtistFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoRemoveDownloaded;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowTooltips;
        private System.Windows.Forms.ToolStripMenuItem tsmiBitrate;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderFields;
        private System.Windows.Forms.ToolStripTextBox tstbMusicPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiColumns;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateAlbumFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderArtist;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderAlbum;
        private System.Windows.Forms.ToolStripMenuItem tsmiColTrackNumber;
        private System.Windows.Forms.ToolStripMenuItem tsmiColName;
        private System.Windows.Forms.ToolStripMenuItem tsmiColArtist;
        private System.Windows.Forms.ToolStripMenuItem tsmiColAlbum;
        private System.Windows.Forms.ToolStripMenuItem tsmiColYear;
        private System.Windows.Forms.ToolStripMenuItem tsmiColGenre;
        private System.Windows.Forms.ToolStripMenuItem tsmiColGrouping;
        private System.Windows.Forms.ToolStripMenuItem tsmiColTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiColLyrics;
        private System.Windows.Forms.ToolStripMenuItem tsmiColComposer;
        private System.Windows.Forms.ToolStripMenuItem tsmiColDiscNumber;
        private System.Windows.Forms.ToolStripMenuItem tsmiColBitrate;
        private System.Windows.Forms.ToolStripMenuItem tsmiColID;
        private System.Windows.Forms.ToolStripMenuItem tsmiColStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderYear;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderGenre;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderGrouping;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiBitrateMin;
        private System.Windows.Forms.ToolStripMenuItem tsmiBitrateMax;
        private System.Windows.Forms.ToolStripComboBox tscbGenre;
        private System.Windows.Forms.ToolStripComboBox tscbGrouping;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorBackground;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorGridBackground;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeaderComposer;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearSorting;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditOnEnter;
        private System.Windows.Forms.ToolStripMenuItem tsmiColImage;
        private System.Windows.Forms.Label lblComposer;
        public System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cLyrics;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cComposer;
        private System.Windows.Forms.DataGridViewComboBoxColumn cBitrate;
        private System.Windows.Forms.DataGridViewImageColumn cImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiscNumber;
        private System.Windows.Forms.ToolStripMenuItem tsmiClean;
    }
}

