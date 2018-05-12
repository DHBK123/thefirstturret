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
using YoutubeSearch;

using Google.GData.YouTube;
using Google.GData.Extensions;
using Google.GData.Client;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;



namespace YouTubePlayerKara
{
    public partial class SearchList : Form
    {
        public SearchList()
        {
            InitializeComponent();
        }
         
        private void btnSearch_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<SearchVideo> _list = new List<SearchVideo>();
            
            foreach (var item in items.SearchQuery(tbSearch.Text, 1))
            {
                SearchVideo _video = new SearchVideo();
                _video.Title = item.Title;
                _video.Author = item.Author;
                _video.Url = item.Url;
                byte[] imageDatas = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageDatas))
                {
                    _video.Thumbnail = Image.FromStream(ms);
                }
                _list.Add(_video);
            }
            searchVideoBindingSource.DataSource = _list;
        }
        private void dtGridSearchView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridSearchView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtGridSearchView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtGridSearchView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["urlDataGridViewTextBoxColumn"].Value);
                MinScreen mins = new MinScreen(a);
                mins.Visible = true;
            }
        }
    }
}
