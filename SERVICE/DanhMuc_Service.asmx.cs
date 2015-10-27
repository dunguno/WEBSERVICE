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
    /// Summary description for DanhMuc_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DanhMuc_Service : System.Web.Services.WebService
    {
        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable DanhMuc_GetByAll()
        {
            DataTable mytb = new DataTable("Get_ALL");
            string query = "select * from PhanLoai";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable DanhMuc_GetByName(string ten_loai)
        {
            DataTable mytb = new DataTable("Get_ALL");
            string query = "select * from PhanLoai where ten_loai LIKE '%"+ten_loai+"%'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_DanhMuc(int ma_loai)
        {
            try
            {
                string sql = "delete from PhanLoai where ma_loai = '" + ma_loai + "' ";
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
        public bool Update_DanhMuc(int ma_loai, string ten_loai)
        {
            try
            {
                string sql = "UPDATE PhanLoai SET ten_loai=N'" + ten_loai + "' WHERE ma_loai =N'" + ma_loai + "'";
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
        public bool Insert_DanhMuc(string ten_loai)
        {
            try
            {
                string sql = "INSERT INTO PhanLoai VALUES(N'" + ten_loai + "')";
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
