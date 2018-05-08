using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubePlayerKara
{
    public partial class InitScreen : Form
    {
        public InitScreen()
        {
            InitializeComponent();
        }

        private void btnPlaySearch_Click(object sender, EventArgs e)
        {
            SearchList _searchList = new SearchList();
            _searchList.Visible = true; 
            
        }
    }
}
