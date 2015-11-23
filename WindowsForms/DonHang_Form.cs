using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForms.DonHang_ServiceReferences;

namespace WindowsForms
{
    public partial class DonHang_Form : Form
    {
        DonHang_ServiceReferences.DonHang_Service donhang = new DonHang_ServiceReferences.DonHang_Service();
        NhanVien_ServiceReferences.NhanVien_Service nhanvien = new NhanVien_ServiceReferences.NhanVien_Service();
        public static int ma_donhang;

        public DonHang_Form()
        {
            InitializeComponent();
        }

        private void DonHang_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDonhang.DataSource = donhang.DonHang_GetAll();
            string[] columns = { "ngay_dat", "tinh_trang", "ma_kh", "ma_nv" };
            Ultilities.DataGridViewFormat(dgvDonhang, columns);
        }

        private void DataBinding()
        {
            cbTinhtrang.Text = dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["tinh_trang"].Value.ToString();
            cbNhanvien.Text = nhanvien.NhanVien_GetName(int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_nv"].Value.ToString()));
        }

        private void DataBinding_InfoKhachHang()
        {
            int ma_kh = int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_kh"].Value.ToString());
            DataRow dr = donhang.GetInfo_KhachHang(ma_kh).Rows[0];
            txtMaKH.Text = dr["ma_kh"].ToString();
            txtHoten.Text = dr["hoten"].ToString();
            txtDiachi.Text = dr["diachi"].ToString();
            txtEmail.Text = dr["email"].ToString();
            txtSdt.Text = dr["sdt"].ToString();
        }

        private void Reset()
        {
            cbNhanvien.Text = "";
            cbTinhtrang.Text = "";
            txtMaKH.Text = "";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvDonhang.DataSource = donhang.DonHang_GetByDate(dtpFrom.Value,dtpTo.Value);
            string[] columns = { "ngay_dat", "tinh_trang", "ma_kh", "ma_nv" };
            Ultilities.DataGridViewFormat(dgvDonhang, columns);
        }

        private void btCTDH_Click(object sender, EventArgs e)
        {
            ma_donhang = int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_donhang"].Value.ToString());
            ChiTietDonHang_Form frm = new ChiTietDonHang_Form(ma_donhang);
            frm.ShowDialog();
            LoadData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ma_donhang = int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_donhang"].Value.ToString());
            if (ma_donhang != 0)
            {
                if (donhang.Update_DonHang(ma_donhang, cbTinhtrang.Text, int.Parse(cbNhanvien.SelectedValue.ToString())))
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

        private void dgvDonhang_MouseClick(object sender, MouseEventArgs e)
        {
            DataBinding();
            DataBinding_InfoKhachHang();
        }

        private void cbNhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            cbNhanvien.DataSource = nhanvien.NhanVien_Load();
            cbNhanvien.ValueMember = "ma_nv";
            cbNhanvien.DisplayMember = "ten_nv";
        }
    }
}
