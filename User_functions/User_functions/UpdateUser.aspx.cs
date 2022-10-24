using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class UpdateUser : System.Web.UI.Page
    {

        User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient ();

        string id;
        string pass;
        
        List<string> re = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
             id = Request.QueryString["adi"];
             pass = Request.QueryString["soyadi"];

            re = web.ViewUserInfo(id,pass);  
            if (!IsPostBack)
            {
                u_t1.Text = re[1];
                u_t2.Text = re[2];
                u_t3.Text = re[3];
                u_t4.Text = re[4];
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (  (u_t1.Text == "") || (u_t2.Text == "") || (u_t3.Text == "") || (u_t4.Text == "") )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please input valid data');", true);
                return;
            }
            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();

            web.UpdateUserInfo(id, pass ,u_t1.Text, int.Parse(u_t2.Text), int.Parse(u_t3.Text),u_t4.Text);
            Response.Redirect("Home Page.aspx?adi=" + id + "&soyadi=" + pass);


        }
    }
}