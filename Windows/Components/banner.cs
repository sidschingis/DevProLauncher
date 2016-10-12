using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DevProLauncher.Windows.Components
{
    public partial class Banner : Form
    {
        private string linkurl;

        public Banner(string name, string link, Image image)
        {
            InitializeComponent();
            TopLevel = false;
            //Dock = DockStyle.Fill;
            //Anchor = AnchorStyles.Top;
            Visible = true;
            linkurl = link;
            BannerImage.Image = image;
        }

        private void BannerImage_Click(object sender, EventArgs e)
        {
            Process.Start(linkurl);
        }
    }
}