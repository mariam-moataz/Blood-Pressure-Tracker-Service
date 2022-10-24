using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class ViewData : System.Web.UI.Page
    {
        string id;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["adi"];
            pass = Request.QueryString["soyadi"];

            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();

            List<string> re = new List<string>();
            re = web.ViewUserInfo(id,pass);
           


            Label0.Text = re[0];
            v_t1.Text = re[1];
            v_t2.Text = re[2];
            v_t3.Text = re[3];
            v_t4.Text = re[4];
            v_t5.Text = re[5];

        }

        protected void v_Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home Page.aspx?adi=" +id + "&soyadi=" + pass);

        }
    }
}