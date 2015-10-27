using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btSanpham_Click(object sender, EventArgs e)
        {
            SanPham_Form frm = new SanPham_Form();
            frm.ShowDialog();
        }

        private void btDanhmuc_Click(object sender, EventArgs e)
        {
            DanhMuc_Form frm = new DanhMuc_Form();
            frm.ShowDialog();
        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
            NhanVien_Form frm = new NhanVien_Form();
            frm.ShowDialog();
        }

        private void btDonhang_Click(object sender, EventArgs e)
        {
            DonHang_Form frm = new DonHang_Form();
            frm.ShowDialog();
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            KhachHang_Form frm = new KhachHang_Form();
            frm.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            lbUser.Text = "Chào " + DangNhap_Form.hotenNV;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            DangNhap_Form frm = new DangNhap_Form();
            this.Hide();
            frm.Show();
        }
    }
}
