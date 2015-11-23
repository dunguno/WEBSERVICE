using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class KhachHang_Form : Form
    {
        KhachHang_ServiceReferences.KhachHang_Service khachhang = new KhachHang_ServiceReferences.KhachHang_Service();
        public KhachHang_Form()
        {
            InitializeComponent();
        }

        private void KhachHang_Form_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadData()
        {
            dgvKhachhang.DataSource = khachhang.KhachHang_GetAll();
            string[] columns = { "ma_kh", "hoten" };
            Ultilities.DataGridViewFormat(dgvKhachhang, columns);
        }

        private void DataBinding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("text", dgvKhachhang.DataSource, "ma_kh");

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dgvKhachhang.DataSource, "hoten");

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("text", dgvKhachhang.DataSource, "sdt");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", dgvKhachhang.DataSource, "diachi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dgvKhachhang.DataSource, "email");

            txtAcc.DataBindings.Clear();
            txtAcc.DataBindings.Add("text", dgvKhachhang.DataSource, "username");

            txtPass.DataBindings.Clear();
            txtPass.DataBindings.Add("text", dgvKhachhang.DataSource, "pass");
        }

        private void Reset()
        {
            txtMaKH.Text = "";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtAcc.Text = "";
            txtPass.Text = "";
        }
        private void dgvKhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            DataBinding();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (khachhang.Delete_KhachHang(int.Parse(txtMaKH.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng cần xóa");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                if (khachhang.Update_KhachHang(int.Parse(txtMaKH.Text), txtHoten.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text, txtAcc.Text, txtPass.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (khachhang.Insert_KhachHang(txtHoten.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text, txtAcc.Text, txtPass.Text))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                Reset();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
            {
                dgvKhachhang.DataSource = khachhang.KhachHang_GetByName(txtTim.Text);
                string[] columns = { "ma_kh", "hoten" };
                Ultilities.DataGridViewFormat(dgvKhachhang, columns);
            }
            else
            {
                MessageBox.Show("Nhập tên khách hàng cần tìm!");
                txtTim.Focus();
            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
            txtTim.Text = "";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
