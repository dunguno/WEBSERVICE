using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SERVICE
{
    /// <summary>
    /// Summary description for Connect_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Connect_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string ChuoiKetNoi()
        {
            return @"Data Source=HUY;Initial Catalog=BakeryShop;Integrated Security=True";
        }
    }
}
