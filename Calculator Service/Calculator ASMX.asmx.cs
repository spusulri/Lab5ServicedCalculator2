using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_Service
{
    /// <summary>
    /// Summary description for Calculator_ASMX
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator_ASMX : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add (double f1, double f2)
        {
            return f1 + f2;
        }
        [WebMethod]
        public double Subtrct(double f1, double f2)
        {
            return f1 - f2;
        }
        [WebMethod]
        public double Multiply(double f1, double f2)
        {
            return f1 * f2;
        }
        [WebMethod]
        public double Divide(double f1, double f2)
        {
            return f1 / f2;
        }
        [WebMethod]
        public double Halve(double f1)
        {
            return f1 / 2;
        }

        [WebMethod]
        public double Quarter(double f1)
        {
            return f1 / 4;
        }

    }
}
