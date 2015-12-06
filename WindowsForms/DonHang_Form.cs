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
        ChiTietDonHang_ServiceReferences.ChiTietDonHang_Service ctdh = new ChiTietDonHang_ServiceReferences.ChiTietDonHang_Service();
        NhanVien_ServiceReferences.NhanVien_Service nhanvien = new NhanVien_ServiceReferences.NhanVien_Service();
        KhachHang_ServiceReferences.KhachHang_Service khachhang = new KhachHang_ServiceReferences.KhachHang_Service();

        public static int ma_donhang;

        public DonHang_Form()
        {
            InitializeComponent();
        }

        private void DonHang_Form_Load(object sender, EventArgs e)
        {
            LoadData();
            //Check_KhachHang();
        }

        private void Check_KhachHang()
        {
            if (checkKH.Checked == true)
            {
                txtTimKH.Enabled = false;
                btTimKH.Enabled = false;
                panelKH.Enabled = true;
            }
            else
            {
                txtTimKH.Enabled = true;
                btTimKH.Enabled = true;
                //panelKH.Enabled = false;
            }

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

        private void Search_InfoKhachHang()
        {
            string sdt = txtTimKH.Text;
            DataRow dr = donhang.GetInfo_KhachHangPhone(sdt).Rows[0];
            if (dr == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!");
            }
            else
            {
                txtMaKH.Text = dr["ma_kh"].ToString();
                txtHoten.Text = dr["hoten"].ToString();
                txtDiachi.Text = dr["diachi"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtSdt.Text = dr["sdt"].ToString();
            }
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

        private void btDel_Click(object sender, EventArgs e)
        {
            ma_donhang = int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_donhang"].Value.ToString());
            if (ma_donhang != 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if ((ctdh.Delete_ChiTietDonHang(ma_donhang)) && (donhang.Delete_DonHang(ma_donhang)))
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
                MessageBox.Show("Hãy chọn đơn hàng cần xóa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma_donhang = int.Parse(dgvDonhang.Rows[dgvDonhang.CurrentCell.RowIndex].Cells["ma_donhang"].Value.ToString());
            InDonHang_Form frm = new InDonHang_Form();
            frm.ShowDialog();
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            Search_InfoKhachHang();
        }

        private void checkKH_CheckedChanged(object sender, EventArgs e)
        {
            Check_KhachHang();
            Reset();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(donhang.Insert_DonHang(DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy")), cbTinhtrang.Text, int.Parse(txtMaKH.Text),int.Parse("1")))
            {
                MessageBox.Show("Thành công");
            }
            //DataRow dr = khachhang.KhachHang_GetLastID().Rows[0];
            //int ma_kh = int.Parse(dr["ma_kh"].ToString()) + 1;
            //string username = "KH"+ma_kh.ToString();
            //if(checkKH.Checked == true)
            //{
            //    if(khachhang.Insert_KhachHang(txtHoten.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text, username, "12345"))
            //    {
            //        donhang.Insert_DonHang(DateTime.Today,"Đang xử lý",ma_kh,int.Parse(cbNhanvien.SelectedValue.ToString()));
            //        DataRow drDH = donhang.DonHang_GetLastID().Rows[0];
            //        ma_donhang = int.Parse(drDH["ma_donhang"].ToString());
            //        ChiTietDonHang_Form frm = new ChiTietDonHang_Form(ma_donhang);
            //        frm.ShowDialog();
            //    }
            //}
            //else
            //{
            //    if (donhang.Insert_DonHang(DateTime.Today, "Đang xử lý", int.Parse(txtMaKH.Text), int.Parse(cbNhanvien.SelectedValue.ToString())))
            //    {
            //        MessageBox.Show("fsdsfsdf");
            //        //DataRow drDH = donhang.DonHang_GetLastID().Rows[0];
            //        //ma_donhang = int.Parse(drDH["ma_donhang"].ToString());
            //        //ChiTietDonHang_Form frm = new ChiTietDonHang_Form(ma_donhang);
            //        //frm.ShowDialog();
            //    }

            //}
        }

    }
}
