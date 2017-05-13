using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class pat_req : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["fullname"] != null)
            {
                string doc = Session["fullname"].ToString();
                pid.Text = Session["uid"].ToString();
                pname.Text = Session["fullname"].ToString();
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
                            while (reader.Read())
                            {
                                docn.Items.Add(reader.GetString(1));
                            }
                        }
                    }
                }
                using (var connection = new MySqlConnection(connectionInfo))
                {
                    connection.Open();
                    var command = new MySqlCommand("Select * From `appointment` WHERE patname='" + doc + "' AND `status`='request';", connection);
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
                                //LiteralInfo.Text += "<td><a class='btn btn-warning btn-sm' href='request.aspx?item=" + reader.GetString(0) + "'>Go To</a></td></ tr >";
                                LiteralInfo.Text += "</tr>";
                            }
                            LiteralInfo.Text += "</table>";
                        }
                    }
                }
            }else { Response.Redirect("/login.aspx"); }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string pi = pid.Text;
            string pn = pname.Text;
            string dy = day.Text;
            string dt = date.Text;
            string tm = time.Text;
            string dn = docn.Text;

            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into `appointment` (patid, patname, docname, aptday, aptdate, apttime) Values (?PI, ?PN, ?DN, ?AD, ?AE, ?AT);", connection);
                command.Parameters.AddWithValue("?PI", pi);
                command.Parameters.AddWithValue("?PN", pn);
                command.Parameters.AddWithValue("?DN", dn);
                command.Parameters.AddWithValue("?AD", dy);
                command.Parameters.AddWithValue("?AE", dt);
                command.Parameters.AddWithValue("?AT", tm);
                if (command.ExecuteNonQuery() > 0)
                {
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