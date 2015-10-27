using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SanPhamChiTiet_Form : Form
    {
        public SanPhamChiTiet_Form()
        {
            InitializeComponent();
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.png; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBoxSP.Image = new Bitmap(open.FileName);
                // image file path
                txtUrl.Text = open.SafeFileName;
                string newPathToFile = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\" + open.SafeFileName);

                System.IO.File.Copy(open.FileName, newPathToFile, true);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {

        }

        private void SanPhamChiTiet_Form_Load(object sender, EventArgs e)
        {
            pictureBoxSP.Image = Image.FromFile(Application.StartupPath.Replace(Ultilities.WindowsForms, Ultilities.Website + "conheo2.jpg"));
        }
    }
}
