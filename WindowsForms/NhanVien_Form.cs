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
    public partial class NhanVien_Form : Form
    {
        NhanVien_ServiceReferences.NhanVien_Service nhanvien = new NhanVien_ServiceReferences.NhanVien_Service();

        public NhanVien_Form()
        {
            InitializeComponent();
        }

        private void NhanVien_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvNhanvien.DataSource = nhanvien.NhanVien_GetAll();
            string[] columns = { "ma_nv", "ten_nv" };
            Ultilities.DataGridViewFormat(dgvNhanvien, columns);
        }

        private void DataBinding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("text", dgvNhanvien.DataSource, "ma_nv");

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dgvNhanvien.DataSource, "ten_nv");

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("text", dgvNhanvien.DataSource, "sdt");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", dgvNhanvien.DataSource, "diachi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dgvNhanvien.DataSource, "email");

            txtAcc.DataBindings.Clear();
            txtAcc.DataBindings.Add("text", dgvNhanvien.DataSource, "account");

            txtPass.DataBindings.Clear();
            txtPass.DataBindings.Add("text", dgvNhanvien.DataSource, "pass");
        }

        private void Reset()
        {
            txtMaNV.Text = "";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtAcc.Text = "";
            txtPass.Text = "";
        }
        private void dgvNhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            DataBinding();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (nhanvien.Delete_NhanVien(int.Parse(txtMaNV.Text)))
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
                MessageBox.Show("Hãy chọn nhân viên cần xóa");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                if (nhanvien.Update_NhanVien(int.Parse(txtMaNV.Text),txtHoten.Text,txtSdt.Text,txtDiachi.Text,txtEmail.Text,txtAcc.Text,txtPass.Text))
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
            if (nhanvien.Insert_NhanVien(txtHoten.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text, txtAcc.Text, txtPass.Text))
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
                dgvNhanvien.DataSource = nhanvien.NhanVien_GetByName(txtTim.Text);
                string[] columns = { "ma_nv", "ten_nv" };
                Ultilities.DataGridViewFormat(dgvNhanvien, columns);
            }
            else
            {
                MessageBox.Show("Nhập tên nhân viên cần tìm!");
                txtTim.Focus();
            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
            txtTim.Text = "";
        }
    }
}
