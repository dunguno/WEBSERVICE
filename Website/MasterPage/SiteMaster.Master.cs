using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website.MasterPage
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        DanhMuc_Service.DanhMuc_ServiceSoapClient danhmuc = new DanhMuc_Service.DanhMuc_ServiceSoapClient();
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        KhachHang_Service.KhachHang_ServiceSoapClient khachhang = new KhachHang_Service.KhachHang_ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDanhMuc();
                ShowDropDownListDanhMuc();
                KiemTraDN();
            }  
        }

        private void GetDanhMuc()
        {
            DataListDanhMuc.DataSource = danhmuc.DanhMuc_GetByAll();
            DataListDanhMuc.DataBind();
        }

        public void ShowDropDownListDanhMuc()
        {
            ListItem defaut = new ListItem("[Chọn loại bánh]", "-1", true); 
            defaut.Selected = true;
            DropDownListDanhMuc.Items.Add(defaut);
            for (int i = 0; i < danhmuc.DanhMuc_GetByAll().Rows.Count; i++)
            {
                ListItem item = new ListItem(danhmuc.DanhMuc_GetByAll().Rows[i]["ten_loai"].ToString(), danhmuc.DanhMuc_GetByAll().Rows[i]["ma_loai"].ToString());
                DropDownListDanhMuc.Items.Add(item);
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable tb_TimKiem = sanpham.SanPham_Search(txtSearch.Text);
                //sv_sach.TimKiemNangCao(tensach, maloai, giamin, giamax);
            if (tb_TimKiem.Rows.Count == 0)
            {
                Response.Write("<script language='JavaScript'> alert('Không tìm thấy sản phẩm!!'); </script>");
            }
            else
            {
                Session["TimKiem"] = tb_TimKiem;
                Response.Redirect("Product.aspx");
            }
        }

        protected void btSearchAdvance_Click(object sender, EventArgs e)
        {
            string tensp = txtTenSP.Text;
            int loai = int.Parse(DropDownListDanhMuc.SelectedValue);
            string gia_Min = txtGia_Min.Text;
            string gia_Max = txtGia_Max.Text;

            for (int i = 0; i < gia_Min.Length; i++)
            {
                if (!char.IsNumber(gia_Min[i]))
                {
                    Response.Write("<script language='JavaScript'> alert('Giá phải là số nguyên dương!!'); </script>");
                    txtGia_Min.Text = "";
                    return;
                }
            }

            for (int i = 0; i < gia_Max.Length; i++)
            {
                if (!char.IsNumber(gia_Max[i]))
                {
                    Response.Write("<script language='JavaScript'> alert('Giá phải là số nguyên dương!!'); </script>");
                    txtGia_Max.Text = "";
                    return;
                }

            }
            if (gia_Max != "" && gia_Min != "")
            {
                if (Convert.ToInt32(gia_Max) < Convert.ToInt32(gia_Min))
                {
                    Response.Write("<script language='JavaScript'> alert('Giá phải từ thấp đến cao!!'); </script>");
                    txtGia_Max.Text = "";
                    return;
                }

            }

            DataTable tb_TimKiemNangCao = sanpham.SanPham_SearchAdvanced(tensp, loai, int.Parse(gia_Min), int.Parse(gia_Max));
            if (tb_TimKiemNangCao.Rows.Count == 0)
            {
                Response.Write("<script language='JavaScript'> alert('Không tìm thấy sản phẩm!!'); </script>");
            }
            else
            {
                Session["TimKiemNangCao"] = tb_TimKiemNangCao;
                Response.Redirect("Product.aspx");
            }
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            string ten = txtUser.Text;
            string matkhau = txtPass.Text;
            if (khachhang.KhachHang_CheckLogin(ten, matkhau).Rows.Count == 0)
            {
                Response.Write("<script language='JavaScript'> alert('Sai tên đăng nhập hoặc mật khẩu !!'); </script>");
            }
            else
            {
                DataTable tb_KhachHang = khachhang.KhachHang_GetByUsername(ten);
                Session["KhachHang_DN"] = tb_KhachHang;
                KiemTraDN();
                Response.Redirect("Product.aspx");
            }
        }

        protected void LinkBtnThoat_Click(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("Product.aspx");
        }

        public void KiemTraDN()
        {
            if (Session["KhachHang_DN"] == null)
            {
                paneDangNhap.Visible = true;
                paneInfoKH.Visible = false;
                //pnNV.Visible = false;
                //pnAdmin.Visible = false;
            }
            else
                    if (Session["KhachHang_DN"] != null)
                    {
                        rptDangNhapKH.DataSource = Session["KhachHang_DN"];
                        rptDangNhapKH.DataBind();
                        paneDangNhap.Visible = false;
                        paneInfoKH.Visible = true;
                        //pnNV.Visible = false;
                        //pnAdmin.Visible = false;
                    }
        }

    }
}