using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        DanhMuc_Service.DanhMuc_ServiceSoapClient danhmuc = new DanhMuc_Service.DanhMuc_ServiceSoapClient();
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            string ma_sp = Request.QueryString["ma_sp"];
            DataTable tb_sanpham = sanpham.SanPham_GetByID(Convert.ToInt32(ma_sp));
            ImageSP.ImageUrl = "~/Images/SanPham/" + tb_sanpham.Rows[0]["hinh"].ToString();
            txtTenSP.Text = tb_sanpham.Rows[0]["ten_sp"].ToString();
            txtMota.Text = tb_sanpham.Rows[0]["mo_ta"].ToString();
            txtGia.Text = tb_sanpham.Rows[0]["gia"].ToString();
            string ma_loai = tb_sanpham.Rows[0]["phan_loai"].ToString();

            DataTable tb_loaibanh = danhmuc.DanhMuc_GetByID(Convert.ToInt32(ma_loai));
            txtLoaiBanh.Text = tb_loaibanh.Rows[0]["ten_loai"].ToString();
        }
    }
}