using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Download;

namespace YouTubePlayerKara
{
    public partial class MinScreen : Form
    {
        public string URL { get; set; }
        public MinScreen()
        {
            InitializeComponent();
            btnPlay.Text = "Playing";
        }
        public MinScreen(string url)
        {
            InitializeComponent();
            URL = url.Replace("watch?v=", "embed/");
            URL += "?autoplay=1";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Text = "Paused";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            this.webBrowser1.DocumentText = string.Format(embed, URL);
        }
    }
}
