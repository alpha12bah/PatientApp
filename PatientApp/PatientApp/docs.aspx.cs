using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class docs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From doctor;", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        LiteralInfo.Text += "<table class='table table-hover'>"
                            + "<tr><th>ID</th><th>Name</th><th>Specialty</th><th>Office Address</th></tr>";
                        while (reader.Read())
                        {
                            LiteralInfo.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>",
                                HttpUtility.HtmlEncode(reader.GetString(0)),
                                HttpUtility.HtmlEncode(reader.GetString(1)),
                                HttpUtility.HtmlEncode(reader.GetString(2)),
                                HttpUtility.HtmlEncode(reader.GetString(3))
                                );
                            LiteralInfo.Text += "</ tr >";
                        }
                        LiteralInfo.Text += "</table>";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fn = dname.Text;
            string un = username.Text;
            string em = email.Text;
            string pw = pass.Text;
            string rl = "doctor";
            string off = office.Text;
            string ps = spec.Text;

            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into users (fullname, email, username, password, role) Values (?FN, ?EM, ?UN, ?PASS, ?R);", connection);
                var command1 = new MySqlCommand("Insert Into doctor (name, post, office) Values (?NM, ?PS, ?OF);", connection);
                command1.Parameters.AddWithValue("?NM", fn);
                command1.Parameters.AddWithValue("?PS", ps);
                command1.Parameters.AddWithValue("?OF", off);
                command.Parameters.AddWithValue("?FN", fn);
                command.Parameters.AddWithValue("?EM", em);
                command.Parameters.AddWithValue("?UN", un);
                command.Parameters.AddWithValue("?PASS", pw);
                command.Parameters.AddWithValue("?R", rl);
                if (command.ExecuteNonQuery() > 0)
                {
                    command1.ExecuteNonQuery();
                    LiteralMsg.Text += "<div class='alert alert-success'> Success! " +
                        "Registeration Successful. Proceed Login with your new Username and Password.</ div > ";
                }
                else
                {
                    LiteralMsg.Text += "<div class='alert alert-danger'> Error! " +
                        "Registeration Failed. Please Try Again.</ div > ";
                }
            }
        }
    }
}