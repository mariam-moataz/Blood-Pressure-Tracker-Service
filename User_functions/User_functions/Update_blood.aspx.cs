using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class Update_blood : System.Web.UI.Page
    {
        string id;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["adi"];
            pass = Request.QueryString["soyadi"];

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if ((u_t5.Text == "") )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please input valid data');", true);
                return;
            }
            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();
            web.Update_blood_pressure(id, pass, int.Parse(u_t5.Text));
            Response.Redirect("Home Page.aspx?adi=" + id + "&soyadi=" + pass);

        }

    }
}