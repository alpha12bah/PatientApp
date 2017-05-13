using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["q"] != null && Request.QueryString["q"] == "logout")
            {
                Session.Abandon();
            }
        }

        protected void Login(object sender, EventArgs e)
        {
            string lun = "", lid = "", lpw = "", lrl = "", lem = "", lfn = "";
            string un = user.Text;
            string pw = pass.Text;

            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From users WHERE username='" + un + "' AND password='" + pw + "';", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lid = reader.GetString(0);
                            lun = reader.GetString(3);
                            lpw = reader.GetString(4);
                            lrl = reader.GetString(5);
                            lem = reader.GetString(2);
                            lfn = reader.GetString(1);
                        }
                        if (pw == lpw && un == lun)
                        {
                            LiteralText.Text += "<div class='alert alert-success'> Success! " +
                                "Login Successful.</ div > ";
                            Session.Add("uid", lid);
                            Session.Add("username", lun);
                            Session.Add("fullname", lfn);
                            Session.Add("email", lem);
                            Session.Add("role", lrl);
                            Response.Redirect("/"+lrl+".aspx");
                        }
                        else
                        {
                            LiteralText.Text += "<div class='alert alert-danger'> Error! " +
                                "Wrong Username Or Password.</ div > ";
                        }

                    }
                    else
                    {
                        LiteralText.Text += "<div class='alert alert-danger'> Error! " +
                            "Username Entered Does Not Exist.</ div > ";
                    }
                }
            }

        }
    }
}