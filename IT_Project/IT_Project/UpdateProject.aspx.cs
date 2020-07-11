using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Project
{
    public partial class UpdateProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TextBox1.Attributes.Add("readonly", "readonly");
            TextBox2.Attributes.Add("readonly", "readonly");
            TextBox3.Attributes.Add("readonly", "readonly");
            TextBox4.Attributes.Add("readonly", "readonly");
            TextBox5.Attributes.Add("readonly", "readonly");

            // Connecting to db to populate the project dropdown 
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Select Project");
                int devid = Convert.ToInt32(Request.QueryString["userid"]); //VVIMP FIX CONNECTION STRING
                string query = "select Title from [Project]  where PId in (select ProjectId from [Working] where DeveloperId = @DevId)";
                string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";

                SqlDataReader reader;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DevId", devid);

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DropDownList1.Items.Add(reader["Title"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    Error_msg_lbl.Text = ex.Message.ToString();
                }
                finally
                {
                    con.Close();
                }
            }
            


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String project_name = DropDownList1.SelectedItem.Text;


            string query = "select PId,Title,DurationMonths,Client,Status from [Project] where Title=@projname";
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";

            SqlDataReader reader;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@projname", project_name);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TextBox1.Text = reader["Client"].ToString();
                    TextBox2.Text = reader["Title"].ToString();
                    TextBox8.Text = reader["PId"].ToString();
                    TextBox3.Text = reader["DurationMonths"].ToString();
                    TextBox5.Text = reader["Status"].ToString();

                }

            }
            catch (Exception ex)
            {
                Error_msg_lbl.Text = ex.Message.ToString();
            }

            finally
            {
                con.Close();
            }


            query = "select * from [Working] where ProjectId=@projid";

            connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";

            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@projid", TextBox8.Text);
            TextBox4.Text = "";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TextBox4.Text += reader["DeveloperId"].ToString()+", ";
                }

            }
            catch (Exception ex)
            {
                Error_msg_lbl.Text = ex.Message.ToString();
            }

            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int status;
            int.TryParse(TextBox6.Text, out status);
            string duration = TextBox7.Text;
            string proj_name = TextBox2.Text;

            string query = "Update Project set DurationMonths = @dur, Status = @stat where Title=@projname";
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";


            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@projname", proj_name);
            cmd.Parameters.AddWithValue("@dur", duration);
            cmd.Parameters.AddWithValue("@stat", status);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error_msg_lbl_1.Text = ex.Message.ToString();
            }

            finally
            {
                con.Close();
                Error_msg_lbl_1.Text = "Update Successful";
                Error_msg_lbl_1.ForeColor = System.Drawing.Color.Green;

            }



        }
    }
}