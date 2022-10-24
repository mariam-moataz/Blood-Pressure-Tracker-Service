using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace user_fun
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public static List<string> Userdata = new List<string>();
        public static List<string> User_blood = new List<string>();
        public static List<DateTime> User_blood_Dates = new List<DateTime>();
        [WebMethod]

        public List<string> getUserddata()
        {
            return Userdata;
        }
        [WebMethod]
        public List<string> getUserdblood()
        {
            return User_blood;
        }
        [WebMethod]
        public List<DateTime> getblooddate()
        {
            return User_blood_Dates;
        }
        [WebMethod]
       
        public void insert(string id,string password ,string name, int age, int w, string gender, int bp)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6DF9UC;Initial Catalog=Essam;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into userr (id,name,age,weight,gender,password) values(@zz,@a,@b,@c,@d,@pass)", con);
            SqlParameter p6 = new SqlParameter("@zz", id);
            SqlParameter p1 = new SqlParameter("@a", name);
            SqlParameter p2 = new SqlParameter("@b", age);
            SqlParameter p3 = new SqlParameter("@c", w);
            SqlParameter p4 = new SqlParameter("@d", gender);
            SqlParameter pass = new SqlParameter("@pass", password);

            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(pass);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("insert into blood_tracker(id,blood_pressure,date) values(@IDD,@B_P,@DATE)", con);
            SqlParameter ID = new SqlParameter("@IDD", id);
            SqlParameter DATE = new SqlParameter("@DATE", DateTime.Now);
            SqlParameter B_P = new SqlParameter("@B_P", bp);
            cmd1.Parameters.Add(ID);
            cmd1.Parameters.Add(B_P);
            cmd1.Parameters.Add(DATE);
            cmd1.ExecuteNonQuery();
            con.Close();
         ViewUserInfo(id,password); 


        }

        [WebMethod]
        public void UpdateUserInfo(string PersonID, string pass ,string PersonName, int PersonAge, int PerosnWeight, string PerosnGender)
        {
           
            SqlConnection PeopleData = new SqlConnection("Data Source=DESKTOP-O6DF9UC;Initial Catalog=Essam;Integrated Security=True");
            PeopleData.Open();
            SqlCommand cmd = new SqlCommand("UPDATE userr SET name=@namePara, age=@AgePara, weight=@WeightPara, gender=@GenderPara WHERE id=@IdPara", PeopleData);

            SqlParameter namePara = new SqlParameter("namePara", PersonName);
            SqlParameter AgePara = new SqlParameter("AgePara", PersonAge);
            SqlParameter WeightPara = new SqlParameter("WeightPara", PerosnWeight);
            SqlParameter GenderPara = new SqlParameter("GenderPara", PerosnGender);
            SqlParameter IdPara = new SqlParameter("IdPara", PersonID);

            cmd.Parameters.Add(namePara);
            cmd.Parameters.Add(AgePara);
            cmd.Parameters.Add(WeightPara);
            cmd.Parameters.Add(GenderPara);
            cmd.Parameters.Add(IdPara);

            cmd.ExecuteNonQuery();

              ViewUserInfo(PersonID, pass);

        }

        [WebMethod]
        public void Update_blood_pressure(string id,  string pass ,int bp)
        {
            SqlConnection PeopleData = new SqlConnection("Data Source=DESKTOP-O6DF9UC;Initial Catalog=Essam;Integrated Security=True");
            PeopleData.Open();
            SqlCommand cmd1 = new SqlCommand("insert into blood_tracker(id,blood_pressure,date) values(@zz,@e,@d)", PeopleData);
            SqlParameter Id = new SqlParameter("zz", id);
            SqlParameter p7 = new SqlParameter("@d", DateTime.Now);
            SqlParameter p8 = new SqlParameter("@e", bp);
            cmd1.Parameters.Add(p7);
            cmd1.Parameters.Add(p8);
            cmd1.Parameters.Add(Id);
            cmd1.ExecuteNonQuery();
            PeopleData.Close();
            ViewUserInfo(id, pass);
        }

        [WebMethod]
        public List<string> ViewUserInfo(string PersonId,string passs)
        {

            Userdata.Clear();
            User_blood.Clear();
            User_blood_Dates.Clear();

            SqlConnection PeopleData = new SqlConnection("Data Source=DESKTOP-O6DF9UC;Initial Catalog=Essam;Integrated Security =True");
            PeopleData.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM userr WHERE id=@IdPara and password=@pass", PeopleData);
            SqlParameter IdPara = new SqlParameter("@IdPara", PersonId);
            SqlParameter p = new SqlParameter("@pass", passs);
            cmd.Parameters.Add(IdPara);
            cmd.Parameters.Add(p);
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (!reader.HasRows)
                    throw new Exception();
                while (reader.Read())
                {
                    Userdata.Add(reader[0].ToString().Trim());
                    Userdata.Add(reader[1].ToString().Trim());
                    Userdata.Add(reader[2].ToString().Trim());
                    Userdata.Add(reader[3].ToString().Trim());
                    Userdata.Add(reader[4].ToString().Trim());
                }
                reader.Close();

                /*get last blood_pressure from blood_pressure  */

                SqlCommand cmd_2 = new SqlCommand("SELECT blood_pressure ,date FROM blood_tracker WHERE id = @IdPara ORDER BY blood_tracker.date ;", PeopleData);
                SqlParameter Id = new SqlParameter("@IdPara", PersonId);

                cmd_2.Parameters.Add(Id);
        
                SqlDataReader reader2 = cmd_2.ExecuteReader();

                while (reader2.Read())
                {
                    User_blood.Add(reader2[0].ToString().Trim());
                    User_blood_Dates.Add(Convert.ToDateTime(reader2[1]));
                }
                cmd_2.Cancel();
                cmd.Cancel();
                reader2.Close();
                PeopleData.Close();
                Userdata.Add((User_blood[User_blood.Count - 1]));
            }
            catch ( Exception e)
            {
                return null;
            }
            return Userdata;
        }

        [WebMethod]
        public bool check(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6DF9UC;Initial Catalog=Essam;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select id from blood pressure tracker where id = @x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);

            if (cmd.ExecuteScalar().ToString() == id)
            {
                con.Close();
                return true;
            }
            else
                return false;



        }
   

            [WebMethod]
            public string blood_pressure()
            {

                
                if (int.Parse(Userdata[Userdata.Count-1])  > 120 && int.Parse(Userdata[Userdata.Count - 1]) < 140)
                {
                    return "you have Prehypertension you should take care of yourself by follwing diet plan:\n" +
                        "1- Watch the salt\n" +
                        "2- Move more\n" +
                        "3- Get to a healthy weight\n" +
                        "4- Limit alcohol/n" +
                        "5- Curb stress\n" +
                        "6- Keep up with your blood pressure";
                }

                else if (int.Parse(Userdata[Userdata.Count - 1]) > 140)
                {
                    return "you have high blood pressure you should follow dash diet the diet is simple:\n " +
                        "1- Eat more fruits, vegetables, and low-fat dairy foods \n " +
                        "2- Cut back on foods that are high in saturated fat, cholesterol, and trans fats\n" +
                        "3- Eat more whole-grain foods, fish, poultry, and nuts \n" +
                        "4- Limit sodium, sweets, sugary drinks, and red meats";


                }
                else if (int.Parse(Userdata[Userdata.Count - 1]) < 90)
                {
                    return "you have low blood pressure the plan is simple:\n" +
                        "1- Use more salt\n" +
                        "2- Wear compression stockings/n" +
                        "3- Drink more water, less alcohol\n" +
                        "4- Pay attention to your body positions\n" +
                        "5- Eat small, low-carb meals.\n" +
                        "6- Exercise regularly";
                }
                else
                    return "your blood pressure is ideal";






            }
        
    }
}
