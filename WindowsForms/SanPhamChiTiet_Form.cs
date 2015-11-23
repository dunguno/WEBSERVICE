using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.SanPham_ServiceReferences;

namespace WindowsForms
{
    public partial class SanPhamChiTiet_Form : Form
    {
        SanPham_ServiceReferences.SanPham_Service sanpham = new SanPham_ServiceReferences.SanPham_Service();
        private int _ma_sp = 0;
        string[] ListAnh = new string[70];
        string[] nguonanh = new string[50];
        string filename = "";
        string AnhHienTai = "";
        string PathToFile = "";
        string Path = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\");
        string newPathToFile = "";
        int Vitrianh = 0;
        int Check = 0;
        int SoAnh = 0;
        string TenAnh = "";
        string TenAnhCuaSP = "";


        public SanPhamChiTiet_Form()
        {
            InitializeComponent();
        }

        public SanPhamChiTiet_Form(int ma_sp)
        {
            this._ma_sp = ma_sp;
            InitializeComponent();
            DataRow dr = sanpham.SanPham_GetByID(ma_sp).Rows[0];
            txtMaSP.Text = dr["ma_sp"].ToString();
            txtTenSP.Text = dr["ten_sp"].ToString();
            txtMota.Text = dr["mo_ta"].ToString();
            txtGia.Text = dr["gia"].ToString();
            //txtUrl.Text = dr["hinh"].ToString();
            cbDanhmuc.Text = sanpham.GetDanhMuc(int.Parse(dr["phan_loai"].ToString()));
            string url = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\" + dr["hinh"].ToString());
            pictureBoxSP.Image = Image.FromFile(url);

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMota.Text = "";
            txtGia.Text = "";
            ResetListAnh();
        }

        private void ResetListAnh()
        {
            for (int i = 0; i < ListAnh.Length; i++)
            {
                if (ListAnh[i] != null)
                {
                    ListAnh[i] = null;
                    nguonanh[i] = null;
                }
                else
                    break;
            }
        }

        private void SanPhamChiTiet_Form_Load(object sender, EventArgs e)
        {
            if (_ma_sp == 0)
            {
                btSave.Text = "Thêm";
            }
        }

        private void LoadData(int ma_sp)
        {
            DataRow dr = sanpham.SanPham_GetByID(ma_sp).Rows[0];
            txtMaSP.Text = dr["ma_sp"].ToString();
            txtTenSP.Text = dr["ten_sp"].ToString();
            txtMota.Text = dr["mo_ta"].ToString();
            txtGia.Text = dr["gia"].ToString();
            //txtUrl.Text = dr["hinh"].ToString();
            cbDanhmuc.Text = sanpham.GetDanhMuc(int.Parse(dr["phan_loai"].ToString()));
            string url = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\" + dr["hinh"].ToString());
            pictureBoxSP.Image = Image.FromFile(url);
        }

        private void Load_cbDanhMuc()
        {
            DataRow dr = sanpham.DanhMuc_Load().Rows[0];

            cbDanhmuc.DataSource = sanpham.DanhMuc_Load();
            cbDanhmuc.ValueMember = "ma_loai";
            cbDanhmuc.DisplayMember = "ten_loai";
        }

        private void cbDanhmuc_MouseClick(object sender, MouseEventArgs e)
        {
            Load_cbDanhMuc();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SanPham_ServiceReferences.SanPham_Service sp = new SanPham_ServiceReferences.SanPham_Service();
            if (_ma_sp == 0)
            {
                if (sp.Insert_SanPham(txtTenSP.Text, txtMota.Text, decimal.Parse(txtGia.Text), TenAnh, int.Parse(cbDanhmuc.SelectedValue.ToString())))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    this.Close();
                }
                else MessageBox.Show("Có lỗi xảy ra!");
            }
            else
            {
                if (sp.Update_SanPham(_ma_sp, txtTenSP.Text, txtMota.Text, decimal.Parse(txtGia.Text), TenAnh, int.Parse(cbDanhmuc.SelectedValue.ToString())))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    this.Close();
                }
                else MessageBox.Show("Có lỗi xảy ra!");
            }

        }

        private void SanPhamChiTiet_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.png; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBoxSP.Image = new Bitmap(open.FileName);
                // image file path
                //txtUrl.Text = open.SafeFileName;
                //string filechualuu = open.SafeFileName;
                //string sourcePath = open.FileName;
                filename = open.SafeFileName;
                PathToFile = open.FileName;
                //newPathToFile = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\" + open.SafeFileName);
                //System.IO.File.Copy(open.FileName, newPathToFile, true);
                for (int i = 0; i < ListAnh.Length; i++)
                {
                    if (ListAnh[i] == null)
                    {
                        ListAnh[i] = filename;
                        break;
                    }
                }
                AnhHienTai = filename;

            }
                                                                            
        }

        private void btSaveImage_Click(object sender, EventArgs e)
        {
            TenAnh = "";

            for (int i = 0; i < ListAnh.Length; i++)
            {
                if (ListAnh[i] == null)
                    break;
                TenAnh = TenAnh + ListAnh[i] + " ";
                newPathToFile = System.IO.Directory.GetCurrentDirectory().Replace("\\WindowsForms\\bin\\Debug", "\\Website\\Images\\SanPham\\" + filename);
                if (!File.Exists(newPathToFile))
                    System.IO.File.Copy(PathToFile, newPathToFile, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMota.Text = TenAnh;
        }

        public void ShowImage(string ten)
        {
            pictureBoxSP.ImageLocation = Path + ten;
        }

        private void btDelImage_Click(object sender, EventArgs e)
        {
            ListAnh = ListAnh.Where(p => p != AnhHienTai).ToArray();
            for (int i = 0; i < ListAnh.Length; i++)
                TenAnh = TenAnh + ListAnh[i] + " ";
            if (ListAnh.Length != 0)
            {
                AnhHienTai = ListAnh[0];
                ShowImage(ListAnh[0]);
            }
            else
            {
                AnhHienTai = null;
            }
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            if (AnhHienTai != null)
            {
                for (int i = 0; i < ListAnh.Length; i++)
                {

                    if (ListAnh[i] != null)
                    {
                        if (ListAnh[i].Equals(AnhHienTai) && i > 0)
                        {
                            ShowImage(ListAnh[i - 1]);
                            AnhHienTai = ListAnh[i - 1].ToString();
                            break;
                        }
                    }
                    else
                        break;
                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (AnhHienTai != null)
            {
                for (int i = 0; i < ListAnh.Length - 1; i++)
                {
                    if (ListAnh[i] != null)
                    {

                        if (ListAnh[i].Equals(AnhHienTai) && i < ListAnh.Length - 1)
                        {
                            if (ListAnh[i + 1] != null)
                            {
                                ShowImage(ListAnh[i + 1]);
                                AnhHienTai = ListAnh[i + 1].ToString();
                                break;

                            }
                            else
                                break;
                        }
                    }
                    else
                        break;
                }
            }
        }
    }
}
