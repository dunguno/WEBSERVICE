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
    /// Summary description for KhachHang_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KhachHang_Service : System.Web.Services.WebService
    {
        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable KhachHang_CheckLogin(string username, string pass)
        {
            try
            {
                DataTable mytb = new DataTable("Get_ALL");
                string query = "SELECT * FROM KhachHang WHERE username = '" + username + "' AND pass = '" + pass + "' ";

                SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(mytb);
                return mytb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataTable KhachHang_GetAll()
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "select * from KhachHang";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable KhachHang_GetByID(int ma_kh)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select * from KhachHang where ma_kh = '" + ma_kh + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }


        [WebMethod]
        public DataTable KhachHang_GetByName(string ten_kh)
        {
            DataTable mytb = new DataTable("Get_ByName");
            string query = "select * from KhachHang where hoten LIKE '%" + ten_kh + "%'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable KhachHang_GetByPhone(string sdt)
        {
            DataTable mytb = new DataTable("Get_ByName");
            string query = "select * from KhachHang where sdt ="+sdt+"'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable KhachHang_GetByUsername(string username)
        {
            DataTable mytb = new DataTable("Get_ByName");
            string query = "select * from KhachHang where username = '" + username + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable KhachHang_CheckUsername(string username)
        {
            DataTable mytb = new DataTable("Get_ByName");
            string query = "select * from KhachHang where username = '" + username + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_KhachHang(int ma_kh)
        {
            try
            {
                string sql = "delete from KhachHang where ma_kh = '" + ma_kh + "' ";
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
        public bool Update_KhachHang(int ma_kh, string hoten, string sdt, string diachi, string email, string username, string pass)
        {
            try
            {
                string sql = "UPDATE KhachHang SET hoten=N'" + hoten + "',sdt=N'" + sdt + "',diachi=N'" + diachi + "',email=N'" + email + "',username=N'" + username + "',pass=N'" + pass + "' WHERE ma_kh =N'" + ma_kh + "'";
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
        public bool Insert_KhachHang(string hoten, string sdt, string diachi, string email, string username, string pass)
         {
             try
             {
                 string sql = "INSERT INTO KhachHang VALUES(N'" + hoten + "',N'" + diachi + "',N'" + sdt + "',N'" + email + "',N'" + username + "',N'" + pass + "')";
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
    }

}
