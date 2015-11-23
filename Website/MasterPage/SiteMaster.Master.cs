using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website.MasterPage
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        DanhMuc_Service.DanhMuc_ServiceSoapClient danhmuc = new DanhMuc_Service.DanhMuc_ServiceSoapClient();
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDanhMuc();
        }

        private void GetDanhMuc()
        {
            DataListDanhMuc.DataSource = danhmuc.DanhMuc_GetByAll();
            DataListDanhMuc.DataBind();
        }

    }
}