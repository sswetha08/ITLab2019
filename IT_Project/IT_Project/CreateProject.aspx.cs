
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace IT_Project
{
    public partial class CreateProject: System.Web.UI.Page
    {
        int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select count(*) from [Project]";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=Project_mgmt;Integrated Security=SSPI";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);            
            SqlDataReader dr;
            try
            {
                con.Open();
                counter = (int)cmd.ExecuteScalar() + 1;
            }
            catch (Exception ex)
            {
                l1.Text = "Error";
            }
            finally
            {
                con.Close();
            }

        }

        protected void butt1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "insert into [Project] values (@a_id,@a_title,@a_duration,@a_client,'0')";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=Project_mgmt;Integrated Security=SSPI";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@a_id", counter);
            cmd.Parameters.AddWithValue("@a_title", tb1.Text);
            cmd.Parameters.AddWithValue("@a_duration", tb2.Text);
            cmd.Parameters.AddWithValue("@a_client", tb3.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                l1.Text = "Error";
            }
            finally
            {
                con.Close();
            }
            l4.Text = tb1.Text + " has been added successfully.";
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
        }
    }
}