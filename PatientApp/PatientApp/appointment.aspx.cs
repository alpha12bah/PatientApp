using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class appointment : System.Web.UI.Page
    {
        string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                    "localhost", "root", "", "patient_apt");
        protected void Page_Load(object sender, EventArgs e)
        {
            string apid = Request.QueryString["item"];

            if (!IsPostBack)
            {
                using (var connection = new MySqlConnection(connectionInfo))
                {
                    connection.Open();
                    var command = new MySqlCommand("Select * From `appointment` WHERE `id`='" + apid + "';", connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String sch = reader.GetString(6) + "," + reader.GetString(4) + " " + reader.GetString(5);
                                aid.Text = apid;
                                pname.Text = reader.GetString(2);
                                day.Text = reader.GetString(4);
                                date.Text = reader.GetString(5);
                                time.Text = reader.GetString(6);
                            }
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pi = aid.Text;
            string pn = pname.Text;
            string dy = day.Text;
            string dt = date.Text;
            string tm = time.Text;

            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE `appointment` SET status=?S " +
                    "WHERE `id`=?Q;", connection);

                command.Parameters.AddWithValue("?S", "closed");
                command.Parameters.AddWithValue("?Q", pi);

                if (command.ExecuteNonQuery() > 0)
                {
                    LiteralMsg.Text += "<div class='alert alert-success'> Success! " +
                        "Appointement Closed.</ div > ";
                }
                else
                {
                    LiteralMsg.Text += "<div class='alert alert-danger'> Error! " +
                        "Failed To Close Appointment . Please Try Again.</ div > ";
                }
            }
        }
    }
}