using System;
using System.Collections.Generic;
using System.Data;
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
        static DataTable tb_giohang = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["Giohang"] == null)
                //{
                //    tb_giohang = Session["Giohang"] as DataTable; 
                    
                //}
                //else
                //{
                    tb_giohang.Rows.Clear();
                    tb_giohang.Columns.Clear();
                    tb_giohang.Columns.Add("ma_sp", typeof(int));
                    tb_giohang.Columns.Add("ten_sp", typeof(string));

                    tb_giohang.Columns.Add("gia", typeof(decimal));
                    tb_giohang.Columns.Add("hinh", typeof(string));

                    tb_giohang.Columns.Add("soluong", typeof(int));
                    tb_giohang.Columns.Add("tong", typeof(decimal), "soluong * gia");
                //}

                GetSanPham();
            }
            
        }

        private void GetSanPham()
        {
            if (Session["TimKiem"] == null && Session["TimKiemNangCao"] == null)
            {
                p.DataSource = sanpham.SanPham_GetAll().DefaultView;
                   
            }
            else if (Session["TimKiem"] != null)
            {
                DataTable tb = (DataTable)Session["TimKiem"];
                p.DataSource = tb.DefaultView;
                Session.Contents.Remove("TimKiem");
            }
            else if (Session["TimKiemNangCao"] != null)
            {
                DataTable tb = (DataTable)Session["TimKiemNangCao"];
                p.DataSource = tb.DefaultView;
                Session.Contents.Remove("TimKiemNangCao");
            }
            p.PageSize = 6;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            //p.DataSource = sanpham.SanPham_GetAll().DefaultView;

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

        protected void DataListSP_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //int ma_sp = int.Parse(DataListSP.DataKeys[e.Item.ItemIndex].ToString());
            //int dem = 0;
            //int a = 0;
            //int i = 0;
            //foreach (DataRow r in tb_giohang.Rows)
            //{
            //    if ((int)r["ma_sp"] == ma_sp)
            //    {
            //        dem = (int)r["soluong"] + 1;
            //        a = i;
            //    }
            //    i++;
            //}

            //DataTable tb = sanpham.SanPham_GetByID(ma_sp);
            //    //sv_sach.Sach_GetByID(ma2);
            //DataRow row = tb_giohang.NewRow();
            //row["ma_sp"] = ma_sp;
            //row["ten_sp"] = tb.Rows[0]["ten_sp"].ToString();

            //row["gia"] = tb.Rows[0]["gia"].ToString();
            //row["hinh"] = tb.Rows[0]["hinh"].ToString();
            
            //if (dem != 0)
            //{
            //    row["soluong"] = dem;
            //    tb_giohang.Rows.RemoveAt(a);

            //}
            //else
            //{
            //    row["soluong"] = 1;
            //}
            //tb_giohang.Rows.Add(row);
            //Session["Giohang"] = tb_giohang;
            //Response.Write("<script language='JavaScript'> alert('Đã thêm vào giỏ hàng'); </script>");

            if (e.CommandName == "muahang")
            {
                if (Session["KhachHang_DN"] == null)
                {
                    //Response.Redirect("Cart.aspx");
                    Response.Write("<script>alert('Chưa đăng nhập!...')</script>");
                }
                else
                {
                    int ma_sp = int.Parse(DataListSP.DataKeys[e.Item.ItemIndex].ToString());
                    string ten_sp = ((Label)e.Item.FindControl("TenSPLabel")).Text;
                    float gia = float.Parse(((Label)e.Item.FindControl("GiaLabel")).Text);
                    int soluong = 1;

                    ////Add vao gio hang

                    foreach (DataRow row in tb_giohang.Rows)
                    {//Kiem tr neu mat hang da co roi thi tang so luong len 1
                        if ((int)row["ma_sp"] == ma_sp)
                        {
                            row["soluong"] = (int)row["soluong"] + 1;
                            goto GioHang;
                        }
                    }
                    tb_giohang.Rows.Add(ma_sp, ten_sp, gia, soluong);
                    GioHang:
                    Session["Giohang"] = tb_giohang;

                    Response.Write("<script>alert('Đã thêm vào giỏ hàng ^.*!...')</script>");
                }

            }
        }


    }
}