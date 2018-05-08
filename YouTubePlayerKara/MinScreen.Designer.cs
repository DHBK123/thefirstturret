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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinScreen));
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.screen1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen1)).BeginInit();
            this.SuspendLayout();
            // 
            // seekBar
            // 
            this.seekBar.Location = new System.Drawing.Point(0, 402);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(444, 45);
            this.seekBar.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(445, 403);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(79, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // volBar
            // 
            this.volBar.Location = new System.Drawing.Point(556, 403);
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(104, 45);
            this.volBar.TabIndex = 3;
            // 
            // screen1
            // 
            this.screen1.Enabled = true;
            this.screen1.Location = new System.Drawing.Point(0, 0);
            this.screen1.Name = "screen1";
            this.screen1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("screen1.OcxState")));
            this.screen1.Size = new System.Drawing.Size(688, 388);
            this.screen1.TabIndex = 4;
            // 
            // MinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screen1);
            this.Controls.Add(this.volBar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.seekBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinScreen";
            this.Text = "MinScreen";
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar volBar;
        private AxShockwaveFlashObjects.AxShockwaveFlash screen1;
    }
}

