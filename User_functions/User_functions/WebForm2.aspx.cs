using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string id;
        string pass; 
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["adi"];
            pass = Request.QueryString["soyadi"];

            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();


            TextBox2.Text = web.blood_pressure();
        }

        protected void v_Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home Page.aspx?adi=" + id + "&soyadi=" + pass);
        }
    }
}