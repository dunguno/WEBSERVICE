﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ChiTietDonHang_Form : Form
    {
        ChiTietDonHang_ServiceReferences.ChiTietDonHang_Service ctdn = new ChiTietDonHang_ServiceReferences.ChiTietDonHang_Service();
        SanPham_ServiceReferences.SanPham_Service sanpham = new SanPham_ServiceReferences.SanPham_Service();
        private int _ma_donhang = 0;
        public ChiTietDonHang_Form()
        {
            InitializeComponent();
        }

        public ChiTietDonHang_Form(int ma_donhang)
        {
            this._ma_donhang = ma_donhang;
            InitializeComponent();
            LoadData(ma_donhang);
        }

        private void ChiTietDonHang_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData(int ma_donhang)
        {
            //int tong = 0;
            txtMaDH.Text = ma_donhang.ToString();
            dgvChiTietDonHang.DataSource = ctdn.ChiTietDonHang_GetByID(ma_donhang);
            string[] columns = { "ma_sp", "ten_sp", "so_luong", "gia", "thanh_tien" };
            Ultilities.DataGridViewFormat(dgvChiTietDonHang, columns);
        }
        private void BindingData()
        {
            int ma_sp = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["ma_sp"].Value.ToString());

            cbSanpham.Text = sanpham.GetSanPham(ma_sp);
            txtGia.Text = dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["gia"].Value.ToString();
            txtSoluong.Value = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["so_luong"].Value.ToString());
            txtThanhtien.Text = dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["thanh_tien"].Value.ToString();        
        }

        private void Load_cbSanPham()
        {
            cbSanpham.DataSource = sanpham.SanPham_Load();
            cbSanpham.ValueMember = "ma_sp";
            cbSanpham.DisplayMember = "ten_sp";
        }

        private void Reset()
        {
            txtGia.Text = "";
            txtSoluong.Value = 0;
            txtThanhtien.Text = "";
            cbSanpham.ResetText();
        }

        private void dgvChiTietDonHang_MouseClick(object sender, MouseEventArgs e)
        {
            BindingData();
        }

        private void cbSanpham_MouseClick(object sender, MouseEventArgs e)
        {
            Load_cbSanPham();
        }

        private void cbSanpham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtGia.Text = sanpham.GetGia(int.Parse(cbSanpham.SelectedValue.ToString()));
            txtThanhtien.Text = (int.Parse(txtSoluong.Value.ToString()) * int.Parse(txtGia.Text)).ToString("0,00.##");
        }

        private void txtSoluong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhtien.Text = (int.Parse(txtSoluong.Value.ToString()) * int.Parse(txtGia.Text)).ToString("0,00.##");
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int ma_sp = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["ma_sp"].Value.ToString());
            if(ctdn.Delete_SanPham(_ma_donhang, ma_sp))
            {
                MessageBox.Show("Xóa thành công");
                LoadData(_ma_donhang);
                Reset();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (ctdn.Insert_ChiTietDonHang(_ma_donhang, int.Parse(cbSanpham.SelectedValue.ToString()), int.Parse(txtSoluong.Value.ToString()), int.Parse(txtGia.Text)))
            {
                MessageBox.Show("Thêm thành công");
                LoadData(_ma_donhang);
                Reset();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int ma_sp = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["ma_sp"].Value.ToString());
            //int so_luong = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["so_luong"].Value.ToString());
            //int gia = int.Parse(dgvChiTietDonHang.Rows[dgvChiTietDonHang.CurrentCell.RowIndex].Cells["gia"].Value.ToString());
            if (ctdn.Update_ChiTietDonHang(_ma_donhang, ma_sp,int.Parse(cbSanpham.SelectedValue.ToString()), int.Parse(txtSoluong.Value.ToString()), int.Parse(txtGia.Text)))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadData(_ma_donhang);
                Reset();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }
    }
}
