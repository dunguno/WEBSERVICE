using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForms.SanPham_ServiceReferences;

namespace WindowsForms
{
    public partial class SanPham_Form : Form
    {
        public static int id_sp = 0;
        SanPham_ServiceReferences.SanPham_Service sanpham = new SanPham_ServiceReferences.SanPham_Service();

        public SanPham_Form()
        {
            InitializeComponent();
        }

        private void SanPham_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSanPham.DataSource = sanpham.SanPham_GetAll();
            string[] columns = { "ma_sp", "ten_sp", "mo_ta", "gia", "phan_loai" };
            Ultilities.DataGridViewFormat (dgvSanPham, columns);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            id_sp = int.Parse(dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex].Cells["ma_sp"].Value.ToString());
            if (id_sp != 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (sanpham.Delete_SanPham(id_sp))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
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
            id_sp = int.Parse(dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex].Cells["ma_sp"].Value.ToString());
            SanPhamChiTiet_Form frm = new SanPhamChiTiet_Form(id_sp);
            frm.ShowDialog();
            LoadData();  
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SanPhamChiTiet_Form frm = new SanPhamChiTiet_Form();
            frm.ShowDialog();
            LoadData();
        }
    }
}
