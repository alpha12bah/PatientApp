using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class pat_apt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["fullname"] != null)
            {
                string doc = Session["fullname"].ToString();
                string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                    "localhost", "root", "", "patient_apt");
                using (var connection = new MySqlConnection(connectionInfo))
                {
                    connection.Open();
                    var command = new MySqlCommand("Select * From `appointment` WHERE patname='" + doc + "';", connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            LiteralInfo.Text += "<table class='table table-hover'>"
                                + "<tr><th>ID</th><th>Patient</th><th>Doctor</th><th>Schedule</th><th>Status</th></tr>";
                            while (reader.Read())
                            {
                                String sch = reader.GetString(6) + "," + reader.GetString(4) + "-" + reader.GetString(5);
                                LiteralInfo.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td>",
                                    HttpUtility.HtmlEncode(reader.GetString(0)),
                                    HttpUtility.HtmlEncode(reader.GetString(2)),
                                    HttpUtility.HtmlEncode(reader.GetString(3)),
                                    HttpUtility.HtmlEncode(sch),
                                    HttpUtility.HtmlEncode(reader.GetString(7))
                                    );
                                LiteralInfo.Text += "</ tr >";
                            }
                            LiteralInfo.Text += "</table>";
                        }
                    }
                }
            }
        }
    }
}