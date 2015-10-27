using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForms.NhanVien_ServiceReferences;

namespace WindowsForms
{
    public partial class DangNhap_Form : Form
    {
        NhanVien_ServiceReferences.NhanVien_Service nhanvien = new NhanVien_ServiceReferences.NhanVien_Service();
        public static string hotenNV = "";

        public DangNhap_Form()
        {
            InitializeComponent();
        }

        private void Login()
        {
            DataTable tb = nhanvien.CheckLogin(txtAcc.Text.Trim(), txtPass.Text.Trim());
            if (tb.Rows.Count != 0)
            {
                hotenNV = tb.Rows[0]["ten_nv"].ToString();
                this.Hide();
                Main_Form frm = new Main_Form();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên hoặc mật khẩu không hợp lệ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtAcc.Text = "";
                txtPass.Text = "";
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void DangNhap_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
