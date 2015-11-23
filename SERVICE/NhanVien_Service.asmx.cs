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
    /// Summary description for NhanVien_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NhanVien_Service : System.Web.Services.WebService
    {
        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable CheckLogin(string acc, string pass)
        {
            try
            {
                DataTable mytb = new DataTable("Get_ALL");
                string query = "SELECT * FROM NhanVien WHERE account = '" + acc + "' AND pass = '" + pass + "' ";
                
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
        public DataTable NhanVien_GetAll()
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "select * from NhanVien";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable NhanVien_GetByName(string ten_nv)
        {
            DataTable mytb = new DataTable("Get_ByName");
            string query = "select * from NhanVien where ten_nv LIKE '%"+ten_nv+"%'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public string NhanVien_GetName(int ma_nv)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select ten_nv from NhanVien where ma_nv ='" + ma_nv + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            DataRow dr = mytb.Rows[0];
            string ten_nv = dr[0].ToString();
            return ten_nv;
        }

        [WebMethod]
        public DataTable NhanVien_Load()
        {
            DataTable mytb = new DataTable("Get_ByAll");
            string query = "select * from NhanVien";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_NhanVien(int ma_nv)
        {
            try
            {
                string sql = "delete from NhanVien where ma_nv = '" + ma_nv + "' ";
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
        public bool Update_NhanVien(int ma_nv,string ten_nv, string sdt, string diachi, string email, string acccount, string pass)
        {
            try
            {
                string sql = "UPDATE NhanVien SET ten_nv=N'" + ten_nv + "',sdt=N'" + sdt + "',diachi=N'" + diachi + "',email=N'" + email + "',account=N'" + acccount + "',pass=N'" + pass + "' WHERE ma_nv =N'" + ma_nv + "'";
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
        public bool Insert_NhanVien(string ten_nv, string sdt, string diachi, string email, string acccount, string pass)
        {
            try
            {
                string sql = "INSERT INTO NhanVien VALUES(N'" + ten_nv + "',N'" + sdt + "',N'" + diachi + "',N'" + email + "',N'" + acccount + "',N'" + pass + "')";
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
