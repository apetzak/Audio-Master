namespace Audio_Master
{
    partial class frmGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrid));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrouping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSongCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNullCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNACount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cArtist,
            this.cAlbum,
            this.cGenre,
            this.cYear,
            this.cGrouping,
            this.cSongCount,
            this.cNullCount,
            this.cNACount});
            this.dgvMain.Location = new System.Drawing.Point(12, 42);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(1070, 736);
            this.dgvMain.TabIndex = 0;
            // 
            // cArtist
            // 
            this.cArtist.HeaderText = "Artist";
            this.cArtist.Name = "cArtist";
            this.cArtist.ReadOnly = true;
            this.cArtist.Width = 200;
            // 
            // cAlbum
            // 
            this.cAlbum.HeaderText = "Album";
            this.cAlbum.Name = "cAlbum";
            this.cAlbum.ReadOnly = true;
            this.cAlbum.Width = 200;
            // 
            // cGenre
            // 
            this.cGenre.HeaderText = "Genre";
            this.cGenre.Name = "cGenre";
            // 
            // cYear
            // 
            this.cYear.HeaderText = "Year";
            this.cYear.Name = "cYear";
            // 
            // cGrouping
            // 
            this.cGrouping.HeaderText = "Grouping";
            this.cGrouping.Name = "cGrouping";
            // 
            // cSongCount
            // 
            this.cSongCount.HeaderText = "Song Count";
            this.cSongCount.Name = "cSongCount";
            this.cSongCount.ReadOnly = true;
            // 
            // cNullCount
            // 
            this.cNullCount.HeaderText = "Null Count";
            this.cNullCount.Name = "cNullCount";
            this.cNullCount.ReadOnly = true;
            // 
            // cNACount
            // 
            this.cNACount.HeaderText = "NA Count";
            this.cNACount.Name = "cNACount";
            this.cNACount.ReadOnly = true;
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 790);
            this.Controls.Add(this.dgvMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrid";
            this.Text = "View Lyrics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSongCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNullCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNACount;
    }
}