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
    /// Summary description for DonHang_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DonHang_Service : System.Web.Services.WebService
    {

        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable DonHang_GetAll()
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "select * from DonHang ORDER BY ngay_dat DESC";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable GetInfo_KhachHang(int ma_kh)
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "select * from KhachHang where ma_kh='"+ ma_kh +"'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public DataTable DonHang_GetByDate(DateTime fromDay, DateTime toDay)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select * from DonHang where ngay_dat >='" + fromDay + "' AND ngay_dat <= '" + toDay + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }
        [WebMethod]
        public DataTable DonHang_GetByCustomer(int ma_kh)
        {
            DataTable mytb = new DataTable("Get_ByID");
            string query = "select * from DonHang where ma_kh=N'" + ma_kh + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_DonHang(int ma_dh)
        {
            try
            {
                string sql = "delete from DonHang where ma_donhang = '" + ma_dh + "' ";
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
        public bool Update_DonHang(int ma_donhang, string tinh_trang, int ma_nv)
        {
            try
            {
                string sql = "UPDATE DonHang SET tinh_trang=N'" + tinh_trang + "',ma_nv=N'" + ma_nv + "' WHERE ma_donhang =N'" + ma_donhang + "'";
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
        public bool Insert_DonHang(DateTime ngay_dh, string tinh_trang, int ma_kh, int ma_nv)
        {
            try
            {
                string sql = "INSERT INTO DonHang VALUES(N'" + ngay_dh + "',N'" + tinh_trang + "',N'" + ma_kh + "',N'" + ma_nv + "')";
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
