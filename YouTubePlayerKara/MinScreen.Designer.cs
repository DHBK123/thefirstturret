namespace YouTubePlayerKara
{
    partial class MinScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinScreen));
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.thumbnailDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchMinSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMinSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // seekBar
            // 
            this.seekBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seekBar.BackColor = System.Drawing.Color.Aqua;
            this.seekBar.Location = new System.Drawing.Point(0, 633);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(444, 45);
            this.seekBar.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Location = new System.Drawing.Point(445, 631);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 25);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // volBar
            // 
            this.volBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volBar.BackColor = System.Drawing.Color.Aqua;
            this.volBar.Location = new System.Drawing.Point(556, 634);
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(104, 45);
            this.volBar.TabIndex = 3;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPause.Location = new System.Drawing.Point(503, 631);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 25);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(1042, 634);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 47);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(815, 625);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // gridSearch
            // 
            this.gridSearch.AutoGenerateColumns = false;
            this.gridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thumbnailDataGridViewImageColumn});
            this.gridSearch.DataSource = this.searchMinSBindingSource;
            this.gridSearch.Location = new System.Drawing.Point(821, 54);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.Size = new System.Drawing.Size(228, 571);
            this.gridSearch.TabIndex = 7;
            // 
            // thumbnailDataGridViewImageColumn
            // 
            this.thumbnailDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thumbnailDataGridViewImageColumn.DataPropertyName = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.HeaderText = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.thumbnailDataGridViewImageColumn.MinimumWidth = 35;
            this.thumbnailDataGridViewImageColumn.Name = "thumbnailDataGridViewImageColumn";
            // 
            // searchMinSBindingSource
            // 
            this.searchMinSBindingSource.DataSource = typeof(YouTubePlayerKara.SearchMinS);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(821, 12);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(167, 36);
            this.tbSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(997, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchVideoBindingSource
            // 
            this.searchVideoBindingSource.DataSource = typeof(YouTubePlayerKara.SearchVideo);
            // 
            // MinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1179, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gridSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.volBar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinScreen";
            this.Text = "MinScreen";
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMinSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchVideoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gridSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource searchVideoBindingSource;
        private System.Windows.Forms.BindingSource searchMinSBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailDataGridViewImageColumn;
    }
}

