using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class Home_Page : System.Web.UI.Page
    {
        string id;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["adi"];
            pass = Request.QueryString["soyadi"];
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ViewData.aspx?adi=" + id + "&soyadi=" + pass);

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("UpdateUser.aspx?adi=" +id+ "&soyadi=" + pass);

        }
        protected void update_blood(object sender, EventArgs e)
        {
            Response.Redirect("Update_blood.aspx?adi=" +id + "&soyadi=" + pass);

        }
        protected void DIET(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?adi=" + id + "&soyadi=" + pass);

        }
        protected void Graph(object sender, EventArgs e)
        {
            Response.Redirect("Graph3.aspx?adi=" + id + "&soyadi=" + pass);
            
        }
        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("start.aspx?adi=" + id + "&soyadi=" +pass);

        }
    }
}