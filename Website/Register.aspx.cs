using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Register : System.Web.UI.Page
    {
        KhachHang_Service.KhachHang_ServiceSoapClient khachhang = new KhachHang_Service.KhachHang_ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool KiemTraDangKy()
        {      
            if (khachhang.KhachHang_CheckUsername(txtID.Text).Rows.Count != 0)
            {
                Response.Write("<script language='JavaScript'> alert('Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!'); </script>");
                //RequiredFieldValidator_Username.ErrorMessage = "Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!";
                txtID.Focus();
                return false;
            }
            if (txtName.Text == "")
            {
                //lblTB.Text = "Chưa nhập tên!";
                return false;
            } 
            if (txtPassword.Text == "")
            {
                //lblTB.Text = "Chua nhap mat khau!";
                return false;
            }
            if (txtPassword.Text != txtRePass.Text)
            {
                //lblTB.Text = "Mật khẩu phải trùng khớp!";
                return false;
            }
            else return true;
        }

        private void Reset()
        {
            txtName.Text = "";
            txtID.Text = "";
            txtPassword.Text = "";
            txtRePass.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (KiemTraDangKy() == true)
            {
                khachhang.Insert_KhachHang(txtName.Text, txtMobile.Text, txtAddress.Text, txtEmail.Text, txtID.Text, txtPassword.Text);
                Response.Write("<script language='JavaScript'> alert('Đăng ký thành công!'); </script>");
                Reset();
            }
            else
                Response.Write("<script language='JavaScript'> alert('Lỗi!'); </script>");
        }

    }
}