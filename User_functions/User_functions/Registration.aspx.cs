using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();
            if ((TextBox7.Text == "") || (t1.Text == "") || (t2.Text == "")|| (t3.Text=="") ||(t4.Text=="")||(t5.Text=="") )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please input valid data');", true);
                return;
            }
            web.insert(TextBox7.Text, TextBox1.Text, t1.Text, int.Parse(t2.Text), int.Parse(t3.Text), t4.Text, int.Parse(t5.Text));
            Response.Redirect("Home page.aspx?adi=" + TextBox7.Text + "&soyadi=" + TextBox1.Text);


        }


    }
}