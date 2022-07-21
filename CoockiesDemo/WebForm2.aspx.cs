using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoockiesDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string s = Request.Cookies["mycookie"].Value;
            string s = Request.Cookies["mycookie"]["ids"];
            string s1 = Request.Cookies["mycookie"]["name"];
            Response.Write(s+s1);  
        }
    }
}