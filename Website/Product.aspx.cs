using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Product : System.Web.UI.Page
    {
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        public PagedDataSource p = new PagedDataSource();
        public static int intSTT;
        public static int trang_thu = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetSanPham();
        }

        private void GetSanPham()
        {
            p.PageSize = 6;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            p.DataSource = sanpham.SanPham_GetAll().DefaultView;

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
            DataListSP.DataSource = p;
            DataListSP.DataBind();
        }

        protected void btnDau_Click(object sender, EventArgs e)
        {
            trang_thu = 0;
            GetSanPham();
        }

        protected void btnTruoc_Click(object sender, EventArgs e)
        {
            trang_thu--;
            GetSanPham();
        }

        protected void btnSau_Click(object sender, EventArgs e)
        {
            trang_thu++;
            GetSanPham();
        }

        protected void btnCuoi_Click(object sender, EventArgs e)
        {
            trang_thu = p.PageCount - 1;
            GetSanPham();
        }


    }
}