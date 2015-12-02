using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Cart : System.Web.UI.Page
    {
        SanPham_Service.SanPham_ServiceSoapClient sanpham = new SanPham_Service.SanPham_ServiceSoapClient();
        KhachHang_Service.KhachHang_ServiceSoapClient khachhang = new KhachHang_Service.KhachHang_ServiceSoapClient();
        DonHang_Service.DonHang_ServiceSoapClient donhang = new DonHang_Service.DonHang_ServiceSoapClient();
        ChiTietDonHang_Service.ChiTietDonHang_ServiceSoapClient CTdonhang = new ChiTietDonHang_Service.ChiTietDonHang_ServiceSoapClient();
        static DataTable tbGiohang = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGioHang();
            }
        }

        public void ShowGioHang()
        {
            if (Session["Giohang"] == null)
            {
                Response.Write("<script language='JavaScript'> alert('Chưa có món hàng nào trong giỏ hàng của bạn!!'); </script>");
                //Response.Redirect("sanpham.aspx");
            }
            else
            {
                tbGiohang = (DataTable)Session["Giohang"];
                gridGioHang.DataSource = tbGiohang;
                gridGioHang.DataBind();
                string tong = tbGiohang.Compute("Sum(tong)", "").ToString();
                lbtongtien.Text = tong;
            }
            //if (Request.QueryString["ma_sp"] != null)
            //{
            //    int ma_sp = int.Parse(Request.QueryString["ma_sp"]);
            //    DataTable dt = sanpham.SanPham_GetByID(ma_sp);
            //        //data.get("Select ProName,Price From Products where ProID=" + idSP).Tables[0];
            //    String ten_sp = dt.Rows[0]["ten_sp"].ToString();
            //    int gia = int.Parse(dt.Rows[0]["gia"].ToString());
            //    int soluong = 1;
            //    ThemVaoGioHang(ma_sp, ten_sp, gia, soluong);
            //}
            //if (Session["Giohang"] == null)
            //{
            //    Response.Write("<script language='JavaScript'> alert('Chưa có món hàng nào trong giỏ hàng của bạn!!'); </script>");
                
            //    Response.Redirect("Product.aspx");
            //}
            //else
            //{
            //    //DataTable tb_Khachhang = (DataTable)Session["KhachHang_DN"];
            //    //DataTable tb_Giohang = donhang.DonHang_GetByCustomer(int.Parse(tb_Khachhang.Rows[0]["ma_kh"].ToString()));
            //    //Session["KhachHang_DN"] = tb_KhachHang;
            //    //gridGioHang.DataSource = tb_Giohang;
            //    tbGiohang = (DataTable)Session["Giohang"];
            //    string strnumber = tbGiohang.Compute("Sum(TongTien)", "").ToString();
            //    lbtongtien.Text = strnumber;
            //    gridGioHang.DataSource = tbGiohang;
            //    gridGioHang.DataBind();
            //}
        }

        public void ThemVaoGioHang(int ma_sp, string ten_sp, int gia, int soluong)
        {
            DataTable dt;
            if (Session["Giohang"] == null)
            {
                dt = new DataTable();
                dt.Columns.Add("ma_sp");
                dt.Columns.Add("ten_sp");
                dt.Columns.Add("gia");
                dt.Columns.Add("soluong");
                dt.Columns.Add("tong");
            }
            else
                dt = (DataTable)Session["Giohang"];
            int dong = SPdacotronggiohang(ma_sp, dt);
            if (dong != -1)
            {
                dt.Rows[dong]["soluong"] = Convert.ToInt32(dt.Rows[dong]["soluong"]) + soluong;
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["ma_sp"] = ma_sp;
                dr["ten_sp"] = ten_sp;
                dr["gia"] = gia;
                dr["soluong"] = soluong;
                dr["tong"] = gia * soluong;
                dt.Rows.Add(dr);
            }
            Session["Giohang"] = dt;
        }

        public static int SPdacotronggiohang(int ma_sp, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["ma_sp"].ToString()) == ma_sp)
                {
                    dong = i;
                    break;
                }
            }
            return dong;
        }

        protected void gridGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            string strAgru = e.CommandArgument.ToString();
            string commandname = e.CommandName;

            if (commandname == "Delete")
            {
                DataTable tb = (DataTable)Session["Giohang"];
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (tb.Rows[i]["ma_sp"].ToString() == strAgru)
                    {
                        tb.Rows.RemoveAt(i);
                        Session["Giohang"] = tb;
                        Response.Redirect("Cart.aspx");
                    }
                }

            }
        }

        protected void btnHuyGioHang_Click(object sender, EventArgs e)
        {
            Session["Giohang"] = null;
            Response.Redirect("Product.aspx");
        }

        protected void btnQuayLai_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Session["KhachHang_DN"] == null)
            {
                Response.Redirect("DangNhap.aspx");
            }
            else
            {
                DataTable tb_khachhang = (DataTable)Session["KhachHang_DN"];
                int ma_kh = Convert.ToInt32(tb_khachhang.Rows[0]["ma_kh"].ToString());
                //DataTable tb_loaikh = sv_loaikh.LoaiKH_GetById(maloai);
                //int PhanTramGiam = Convert.ToInt32(tb_loaikh.Rows[0]["PhanTramGiam"].ToString());
                float tongtien = 0;
                foreach (GridViewRow row in gridGioHang.Rows)
                {
                    int gia = Convert.ToInt32(((Label)row.FindControl("LabelGia")).Text);
                    int soluong = Convert.ToInt32(((Label)row.FindControl("txtSoLuong")).Text);
                    tongtien += Convert.ToInt32(gia) * Convert.ToInt32(soluong);
                }
                //tongtien = tongtien - ((tongtien * PhanTramGiam) / 100);
                DateTime ngay_dh = DateTime.Now;
                donhang.Insert_DonHang(ngay_dh, "Đang chờ xử lý", ma_kh, Convert.ToInt32("1"));

                DataTable tb_donhang = donhang.DonHang_GetAll();
                foreach (GridViewRow row in gridGioHang.Rows)
                {
                    int ma_DonHang = Convert.ToInt32(tb_donhang.Rows[tb_donhang.Rows.Count - 1]["ma_donhang"].ToString());
                    int ma_sp = Convert.ToInt32(((Label)row.FindControl("LabelMaSP")).Text);
                    int gia = Convert.ToInt32(((Label)row.FindControl("LabelGia")).Text);
                    int soluong = Convert.ToInt32(((Label)row.FindControl("txtSoLuong")).Text);
                    CTdonhang.Insert_ChiTietDonHang(ma_DonHang, ma_sp, soluong, gia);
                }

                Session["giohang"] = null;
                pnGioHang.Visible = false;
                //lbphantramgiam.Text = "Bạn được giảm " + PhanTramGiam.ToString() + " %";
                lbtongtien.Text = String.Format("{0:N}", tongtien.ToString());
                //pnTongTien.Visible = true;
            }
        }

    }
}