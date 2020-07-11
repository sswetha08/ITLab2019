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
    public partial class MakeComments : System.Web.UI.Page
    {
        int devid;
        int comment_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Select Project");


                devid = Convert.ToInt32(Request.QueryString["userid"]); //VVIMP FIX CONNECTION STRING WITH SWETHA 

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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            String project_name = DropDownList1.SelectedItem.Text;

            string proj_id;

            string query = "select * from [Project] where Title=@projname";
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
                    Label4.Text = reader["PId"].ToString();

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


            project_name = DropDownList1.SelectedItem.Text;
            string comment = TextBox1.Text;

            connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";

            devid = Convert.ToInt32(Request.QueryString["userid"]);

            proj_id = Label4.Text;

            // Label5.Text = proj_id +" "+ devid+" "+ comment+" ";

            SqlConnection con1 = new SqlConnection(connectionString);

            string query1 = "select count(*) from [Comments]";
            connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand(query1, con1);


            try
            {
                con1.Open();



                comment_id = (int)cmd1.ExecuteScalar() + 1;
                Label5.Text = comment_id.ToString();

            }
            catch (Exception ex)
            {
                Error_msg_lbl.Text = ex.Message.ToString();
            }

            finally
            {
                con1.Close();
            }


            string query2 = "insert into [Comments] values (@cid,@pid,@devid,@comment,@review_stat)";
            SqlConnection con2 = new SqlConnection(connectionString);
            SqlCommand cmd2 = new SqlCommand(query2, con2);

            comment_id = int.Parse(Label5.Text);

            //Label5.Text = comment_id+" "+proj_id+" "+ devid+" "+comment;

            cmd2.Parameters.AddWithValue("@cid", comment_id);
            cmd2.Parameters.AddWithValue("@pid", proj_id);
            cmd2.Parameters.AddWithValue("@devid", devid);
            cmd2.Parameters.AddWithValue("@comment", comment);
            cmd2.Parameters.AddWithValue("@review_stat","Pending"); 




            try
            {
                con2.Open();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error_msg_lbl.Text = ex.Message.ToString();
            }

            finally
            {
                con2.Close();

                Error_msg_lbl.Text = "Insert Successful";
                Error_msg_lbl.ForeColor = System.Drawing.Color.Green;

            }
        }
    }
}