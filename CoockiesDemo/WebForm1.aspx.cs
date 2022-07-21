using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoockiesDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("mycookie");
            //c.Value = TextBox1.Text;
            c["ids"] = TextBox1.Text;
            c["name"] = TextBox2.Text;
            c.Expires = DateTime.Now.AddSeconds(30);
            Response.Cookies.Add(c);
            Response.Redirect("WebForm2.aspx");


        }
    }
}