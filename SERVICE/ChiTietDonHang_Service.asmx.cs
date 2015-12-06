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
    /// Summary description for ChiTietDonHang_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ChiTietDonHang_Service : System.Web.Services.WebService
    {
        Connect_ServiceReference.Connect_ServiceSoapClient connect = new Connect_ServiceReference.Connect_ServiceSoapClient();

        [WebMethod]
        public DataTable ChiTietDonHang_GetByID(int ma_donhang)
        {
            DataTable mytb = new DataTable("Get_All");
            string query = "SELECT CTDH.ma_donhang, CTDH.ma_sp, CTDH.so_luong, SP.ten_sp, SP.gia, CTDH.so_luong * SP.gia AS thanh_tien FROM ChiTietDonHang CTDH INNER JOIN Banh SP ON CTDH.ma_sp = SP.ma_sp where ma_donhang ='" + ma_donhang + "'";
            SqlConnection conn = new SqlConnection(connect.ChuoiKetNoi());
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(mytb);
            return mytb;
        }

        [WebMethod]
        public bool Delete_ChiTietDonHang(int ma_dh)
        {
            try
            {
                string sql = "delete from ChiTietDonHang where ma_donhang = '" + ma_dh + "'";
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
        public bool Delete_SanPham(int ma_dh, int ma_sp)
        {
            try
            {
                string sql = "delete from ChiTietDonHang where ma_donhang = '" + ma_dh + "' AND ma_sp = '" + ma_sp + "' ";
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
        public bool Insert_ChiTietDonHang(int ma_dh, int ma_sp, int soluong, int gia)
        {
            try
            {
                string sql = "INSERT INTO ChiTietDonHang VALUES(N'" + ma_dh + "',N'" + ma_sp + "',N'" + soluong + "',N'" + gia + "')";
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
        public bool Update_ChiTietDonHang(int ma_donhang, int ma_sp, int soluong, int gia)
        {
            try
            {
                string sql = "UPDATE ChiTietDonHang SET ma_sp=N'" + ma_sp + "',soluong=N'" + soluong + "', gia=N'" + gia + "' WHERE ma_donhang =N'" + ma_donhang + "'";
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
