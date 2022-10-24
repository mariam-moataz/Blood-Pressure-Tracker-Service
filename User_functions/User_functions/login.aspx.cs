using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace User_functions
{
    public partial class WebForm1 : System.Web.UI.Page
    {



        protected void Button1_Click1(object sender, EventArgs e)
        {


            if ((t10.Text==""))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please input valid data');", true);
                return;
            }
            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();
            List<string> re = new List<string>();
            
                re = web.ViewUserInfo(t10.Text , TextBox1.Text);
           
            if (re == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please input valid data');", true);
                return;
                //Response.Redirect("login.aspx?");

            }
            Response.Redirect("Home page.aspx?adi=" + t10.Text + "&soyadi=" + TextBox1.Text);
           
          

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}