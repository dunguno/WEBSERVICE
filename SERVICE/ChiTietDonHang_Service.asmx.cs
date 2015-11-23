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

    }
}
