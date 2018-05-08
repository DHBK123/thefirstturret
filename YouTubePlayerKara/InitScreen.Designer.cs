namespace YouTubePlayerKara
{
    partial class InitScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitScreen));
            this.lbInit = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPlaySearch = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInit
            // 
            this.lbInit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbInit.AutoSize = true;
            this.lbInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInit.ForeColor = System.Drawing.Color.Blue;
            this.lbInit.Location = new System.Drawing.Point(117, 24);
            this.lbInit.Name = "lbInit";
            this.lbInit.Size = new System.Drawing.Size(562, 31);
            this.lbInit.TabIndex = 0;
            this.lbInit.Text = "WELCOME TO YOUTUBE KARA PLAYER";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(363, 415);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnPlaySearch
            // 
            this.btnPlaySearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPlaySearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPlaySearch.Location = new System.Drawing.Point(215, 90);
            this.btnPlaySearch.Name = "btnPlaySearch";
            this.btnPlaySearch.Size = new System.Drawing.Size(360, 60);
            this.btnPlaySearch.TabIndex = 2;
            this.btnPlaySearch.Text = "PLAY LIST";
            this.btnPlaySearch.UseVisualStyleBackColor = true;
            this.btnPlaySearch.Click += new System.EventHandler(this.btnPlaySearch_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFavorite.Location = new System.Drawing.Point(215, 165);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(360, 60);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "FAVORITES";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // InitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnPlaySearch);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lbInit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitScreen";
            this.Text = "InitScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFavorite;
        public System.Windows.Forms.Button btnPlaySearch;
    }
}