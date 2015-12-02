using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Price : System.Web.UI.Page
    {
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        DanhMuc_Service.DanhMuc_ServiceSoapClient danhmuc = new DanhMuc_Service.DanhMuc_ServiceSoapClient();
        public PagedDataSource p = new PagedDataSource();
        public static int intSTT;
        public static int trang_thu = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }

        public void ShowProduct()
        {
            //int gia_Nho = int.Parse(Request.QueryString["0"]);
            //int gia_Lon = int.Parse(Request.QueryString["100000"]);


            //DataTable dt = danhmuc.DanhMuc_GetByID(Convert.ToInt32(gia));
            //txtDanhMuc.Text = dt.Rows[0]["ten_loai"].ToString();

            p.PageSize = 6;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            p.DataSource = sanpham.SanPham_GetByPrice_Between(int.Parse("100000"),int.Parse("300000")).DefaultView;

            btnDau.Enabled = true;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            btnTruoc.Enabled = true;
            if (p.IsFirstPage == true)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
                btnSau.Enabled = true;
                btnCuoi.Enabled = true;
            }
            if (p.IsLastPage == true)
            {
                btnDau.Enabled = true;
                btnTruoc.Enabled = true;
                btnSau.Enabled = false;
                btnCuoi.Enabled = false;
            }
            txtsoTrang.Text = (trang_thu + 1) + "/" + p.PageCount;
            DataListSP_Price.DataSource = p;
            DataListSP_Price.DataBind();
        }

        protected void btnDau_Click(object sender, EventArgs e)
        {
            trang_thu = 0;
            ShowProduct();
        }

        protected void btnTruoc_Click(object sender, EventArgs e)
        {
            trang_thu--;
            ShowProduct();
        }

        protected void btnSau_Click(object sender, EventArgs e)
        {
            trang_thu++;
            ShowProduct();
        }

        protected void btnCuoi_Click(object sender, EventArgs e)
        {
            trang_thu = p.PageCount - 1;
            ShowProduct();
        }
    }
}