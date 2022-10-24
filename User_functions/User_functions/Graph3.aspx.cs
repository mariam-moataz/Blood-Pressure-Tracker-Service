using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_functions
{
    public partial class Graph3 : System.Web.UI.Page
    {
        User_functionss.WebService1SoapClient web = new User_functionss.WebService1SoapClient();
        string id;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {

            id = Request.QueryString["adi"];
            pass = Request.QueryString["soyadi"];
            List<DateTime> xvalues = new List<DateTime>();
         List<String> yvalues = new List<String>();
            xvalues = web.getblooddate();
            yvalues =  web.getUserdblood();

       



            for (int i = 0; i < xvalues.Count; i++)
                Chart1.Series["boold Pressure"].Points.AddXY(xvalues[i], yvalues[i]);

        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

            List<DateTime> xvalues = new List<DateTime>();
            List<String> yvalues = new List<String>();
            xvalues = web.getblooddate();
            yvalues = web.getUserdblood();



            web.getblooddate();

            for (int i = 0; i < xvalues.Count; i++)
                Chart1.Series["boold Pressure"].Points.AddXY(xvalues[i], yvalues[i]);

            Chart1.Titles.Add("blood pressure Chart");
        }

        protected void v_Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home Page.aspx?adi=" + id + "&soyadi=" + pass);

        }
    }
}