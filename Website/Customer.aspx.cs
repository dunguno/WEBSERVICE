using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Customer : System.Web.UI.Page
    {
        KhachHang_Service.KhachHang_ServiceSoapClient khachhang = new KhachHang_Service.KhachHang_ServiceSoapClient();
        private static string matkhau = "", tendangnhap = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowChiTiet();
            }
        }

        public void ShowChiTiet()
        {
            string makh = Request.QueryString["ma_kh"].ToString();
            int ma_kh = Convert.ToInt32(makh);
            DataTable tb = khachhang.KhachHang_GetByID(ma_kh);
            txtMaKH.Text = tb.Rows[0]["ma_kh"].ToString();
            txtTenKH.Text = tb.Rows[0]["hoten"].ToString();
            txtEmail.Text = tb.Rows[0]["email"].ToString();
            txtDiaChi.Text = tb.Rows[0]["diachi"].ToString();
            txtSoDienThoai.Text = tb.Rows[0]["sdt"].ToString();
            txtTenDangNhap.Text = tb.Rows[0]["username"].ToString();

            tendangnhap = tb.Rows[0]["username"].ToString();
            matkhau = tb.Rows[0]["pass"].ToString();
            
        }

        protected void btnQuayLai_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void linkbtnDoiMK_Click(object sender, EventArgs e)
        {
            lbPass_old.Visible = true;
            lbPass.Visible = true;
            lbRePass.Visible = true;
            txtMatKhau.Visible = true;
            txtMatKhauMoi.Visible = true;
            txtNhapLaiMK.Visible = true;
        }

        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }  

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Visible == true && txtMatKhau.Text != "")
            {
                if (khachhang.KhachHang_CheckLogin(tendangnhap,matkhau).Rows.Count == 0)
                {
                    Response.Write("<script language='JavaScript'> alert('Mật khẩu không đúng!!'); </script>");
                }
                else
                    if (txtMatKhauMoi.Visible == true)
                    {
                        string mkmoi = txtMatKhauMoi.Text;
                        string nhaplaimk = txtNhapLaiMK.Text;
                        if (txtMatKhauMoi.Text == "" || txtNhapLaiMK.Text == "")
                        {
                            Response.Write("<script language='JavaScript'> alert('Mật khẩu không được để trống!!'); </script>");
                        }
                        if (mkmoi != nhaplaimk)
                        {
                            Response.Write("<script language='JavaScript'> alert('Nhập lại mật khẩu chưa đúng!!'); </script>");
                        }
                        matkhau = txtMatKhauMoi.Text;
                    }

                        if (isValidEmail(txtEmail.Text) == false)
                            Response.Write("<script language='JavaScript'> alert('Email không hợp lệ!!'); </script>");
                        else
                            khachhang.Update_KhachHang(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text, txtTenDangNhap.Text, matkhau);
                        Response.Write("<script language='JavaScript'> alert('Cập nhật thông tin thành công!!'); </script>");        
                Response.Redirect("Product.aspx");
            } 
        }

    }
}