using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForms.DanhMuc_ServiceReferences;

namespace WindowsForms
{
    public partial class DanhMuc_Form : Form
    {
        DanhMuc_ServiceReferences.DanhMuc_Service danhmuc = new DanhMuc_ServiceReferences.DanhMuc_Service();
        public DanhMuc_Form()
        {
            InitializeComponent();
        }

        private void DanhMuc_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvDanhmuc_MouseClick(object sender, MouseEventArgs e)
        {
            DataBinding();
        }

        private void LoadData()
        {
            dgvDanhmuc.DataSource = danhmuc.DanhMuc_GetByAll();
            dgvDanhmuc.Columns[0].HeaderText = "Mã loại";
            dgvDanhmuc.Columns[1].HeaderText = "Tên loại";
        }

        private void DataBinding()
        {
            txtMaDM.DataBindings.Clear();
            txtMaDM.DataBindings.Add("text", dgvDanhmuc.DataSource, "ma_loai");
            txtTenDM.DataBindings.Clear();
            txtTenDM.DataBindings.Add("text", dgvDanhmuc.DataSource, "ten_loai");
        }

        private void Reset()
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtTim.Text = "";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (danhmuc.Delete_DanhMuc(int.Parse(txtMaDM.Text)))
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
                MessageBox.Show("Hãy chọn mục cần xóa");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(txtMaDM.Text != "")
            {
                if (danhmuc.Update_DanhMuc(int.Parse(txtMaDM.Text),txtTenDM.Text))
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
            if(danhmuc.Insert_DanhMuc(txtTenDM.Text))
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

        private void btTim_Click(object sender, EventArgs e)
        {
            if(txtTim.Text != "")
            {
                dgvDanhmuc.DataSource = danhmuc.DanhMuc_GetByName(txtTim.Text);
                dgvDanhmuc.Columns[0].HeaderText = "Mã loại";
                dgvDanhmuc.Columns[1].HeaderText = "Tên loại";
            }
            else
            {
                MessageBox.Show("Nhập tên danh mục cần tìm!");
                txtTim.Focus();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
            txtTim.Text = "";
        }

    }
}
