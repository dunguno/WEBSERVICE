using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class ListOrder : System.Web.UI.Page
    {
        KhachHang_Service.KhachHang_ServiceSoapClient khachhang = new KhachHang_Service.KhachHang_ServiceSoapClient();
        DonHang_Service.DonHang_ServiceSoapClient donhang = new DonHang_Service.DonHang_ServiceSoapClient();
        ChiTietDonHang_Service.ChiTietDonHang_ServiceSoapClient CTdonhang = new ChiTietDonHang_Service.ChiTietDonHang_ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            if (Session["KhachHang_DN"] == null)
            {
                Response.Write("<script language='JavaScript'> alert('Bạn phải đăng nhập để sử dụng chức năng này!!'); </script>");
                Response.Redirect("Product.aspx");
            }
            else
            {
                //DataTable tb_KhachHang = new DataTable();
                //tb_KhachHang = (DataTable)Session["KhachHang_DN"];
                string makh = Request.QueryString["ma_kh"].ToString();
                int ma_kh = Convert.ToInt32(makh);
                //int ma_kh = int.Parse(tb_KhachHang.Rows[0]["ma_kh"].ToString());
                DataTable tb = donhang.DonHang_GetByCustomer(ma_kh);
                gridGioHang.DataSource = tb;
                gridGioHang.DataBind();
            }
        }
    }
}