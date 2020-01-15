using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for GetData
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/HouseWS")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetData : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add (int First,int Second)
        {
            return First+Second;
        }
    }
}
