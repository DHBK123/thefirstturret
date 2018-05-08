namespace YouTubePlayerKara
{
    partial class FullScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullScreen));
            this.screen2 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.volBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.screen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            this.SuspendLayout();
            // 
            // screen2
            // 
            this.screen2.Enabled = true;
            this.screen2.Location = new System.Drawing.Point(0, 0);
            this.screen2.Name = "screen2";
            this.screen2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("screen2.OcxState")));
            this.screen2.Size = new System.Drawing.Size(800, 407);
            this.screen2.TabIndex = 0;
            // 
            // seekBar
            // 
            this.seekBar.Location = new System.Drawing.Point(0, 413);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(521, 45);
            this.seekBar.TabIndex = 1;
            // 
            // volBar
            // 
            this.volBar.Location = new System.Drawing.Point(583, 413);
            this.volBar.Maximum = 100;
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(145, 45);
            this.volBar.TabIndex = 2;
            // 
            // FullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volBar);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.screen2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullScreen";
            this.Text = "FullScreen";
            ((System.ComponentModel.ISupportInitialize)(this.screen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash screen2;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.TrackBar volBar;
    }
}