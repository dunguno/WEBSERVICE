using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SERVICE
{
    /// <summary>
    /// Summary description for SanPham_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SanPham_Service : System.Web.Services.WebService
    {
        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable SanPham_GetAll()
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "select * from Banh";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable SanPham_GetByID(int ma_sp)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select * from Banh where ma_sp ='" + ma_sp + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable SanPham_GetByCategories(int ma_loai)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select * from Banh where phan_loai ='" + ma_loai + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_SanPham(int ma_sp)
        {
            try
            {
                string sql = "delete from Banh where ma_sp = '" + ma_sp + "' ";
                SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
                SqlCommand cm = new SqlCommand();
                cm.Connection = conn;
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                conn.Open();
                cm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public bool Update_SanPham(int ma_sp, string ten_sp, string mota, decimal gia, string hinh, int phanloai)
        {
            try
            {
                string sql = "UPDATE Banh SET ten_sp=N'" + ten_sp + "',mo_ta=N'" + mota + "',gia=N'" + gia + "',hinh=N'" + hinh + "',phan_loai=N'" + phanloai + "' WHERE ma_sp =N'" + ma_sp + "'";
                SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
                SqlCommand cm = new SqlCommand();
                cm.Connection = conn;
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                conn.Open();
                cm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public bool Insert_SanPham(string ten_sp, string mota, decimal gia, string hinh, int phanloai)
        {
            try
            {
                string sql = "INSERT INTO NhanVien VALUES(N'" + ten_sp + "',N'" + mota + "',N'" + gia + "',N'" + hinh + "',N'" + phanloai + "')";
                SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
                SqlCommand cm = new SqlCommand();
                cm.Connection = conn;
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                conn.Open();
                cm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public string GetDanhMuc(int ma_danhmuc)
        {
            //DataConnect db = new DataConnect();
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select ten_loai from PhanLoai where ma_loai ='" + ma_danhmuc + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            DataRow dr = mytb.Rows[0];
            string tendanhmuc = dr[0].ToString();
            return tendanhmuc;
        }

        [WebMethod]
        public DataTable DanhMuc_Load()
        {
            DataTable mytb = new DataTable("Get_ByAll");
            string query = "select * from PhanLoai";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable SanPham_Load()
        {
            DataTable mytb = new DataTable("Get_ByAll");
            string query = "select * from Banh";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public string GetSanPham(int ma_sp)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select ten_sp from Banh where ma_sp ='" + ma_sp + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            DataRow dr = mytb.Rows[0];
            string tensp = dr[0].ToString();
            return tensp;
        }

        [WebMethod]
        public string GetGia(int ma_sp)
        {
            //DataConnect db = new DataConnect();
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select gia from Banh where ma_sp ='" + ma_sp + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            DataRow dr = mytb.Rows[0];
            string gia = dr[0].ToString();
            return gia;
        }
    }
}
