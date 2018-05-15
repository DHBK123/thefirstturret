using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Download;
using YoutubeSearch;

namespace YouTubePlayerKara
{
    public partial class MinScreen : Form
    {
        public string URL { get; set; }
        public MinScreen()
        {
            InitializeComponent();


        }
        public MinScreen(string url)
        {
            InitializeComponent();

                URL = url.Replace("watch?v=", "embed/");
                URL = URL.Replace("https", "http");
                URL += "?autoplay=1";
                //URL += "&controls=0";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

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
            "<iframe width=\"800\" height=\"600\"  src=\"{0}\" allow = \"controls = 0\"" +
            "frameborder = \"0\"  allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            this.webBrowser1.DocumentText = string.Format(embed, URL);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //MinScreen minScreen = new MinScreen();
            this.Close();
            //Form cur = Form.ActiveForm;
            //cur.Visible = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<SearchVideo> _list = new List<SearchVideo>();
            foreach (var item in items.SearchQuery(tbSearch.Text, 1))
            {
                SearchVideo _video = new SearchVideo();
                byte[] imageDatas = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageDatas))
                {
                    _video.Thumbnail = Image.FromStream(ms);
                }
                _list.Add(_video);
            }
            searchMinSBindingSource.DataSource = _list; 
        }

        private void gridSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}

