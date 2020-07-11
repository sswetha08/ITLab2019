using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace IT_Project
{
    public partial class GenerateReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Client from [Project] ", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                Status.Items.Add("0-20");
                Status.Items.Add("20-40");
                Status.Items.Add("40-60");
                Status.Items.Add("60-80");
                Status.Items.Add("80-100");
                while (rdr.Read())
                {
                    Client.Items.Add(rdr["Client"].ToString());

                }
                con.Close();
            }

        }

        protected void Clicked(object sender, EventArgs e)
        {
            RadioButtonList1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT * from [Project] where Client = @client AND Status Between @min and @max", con);
            cmd.Parameters.AddWithValue("@client", Client.SelectedValue);
            con.Open();
            int min, max;
            if (Status.SelectedIndex == 0)
            {
                min = 0; max = 20;
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
            }
            else if (Status.SelectedIndex == 1)
            {
                min = 20; max = 40;
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
            }
            else if (Status.SelectedIndex == 2)
            {
                min = 40; max = 60;
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
            }
            else if (Status.SelectedIndex == 3)
            {
                min = 60; max = 80;
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
            }
            else if (Status.SelectedIndex == 3)
            {
                min = 80; max = 100;
                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);
            }

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                RadioButtonList1.Items.Add(rd["Title "].ToString());
            }
            Button2.Visible = true;
            con.Close();

            

        }


        protected void RepButton(object sender, EventArgs e)
        {
            string projname = RadioButtonList1.SelectedValue;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT PId,Status from [Project] where Title = @ptitle", con);
            cmd.Parameters.AddWithValue("@ptitle",projname);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int progress;
            int.TryParse(rdr["Status"].ToString(),out progress);
            int PID;
            int.TryParse(rdr["PId"].ToString(),out PID);
            con.Close();
            con.Open();
            cmd = new SqlCommand("SELECT DeveloperId from [Working] where ProjectId = @pid", con);
            cmd.Parameters.AddWithValue("@pid",PID);
      
            rdr = cmd.ExecuteReader();
            Report.Text = "Report: " + "</br>"  + "Developers working on this project: " + "</br>";
            while (rdr.Read())
            { 
                Report.Text += "Developer ID: " +  rdr["DeveloperId"].ToString() + "</br>";
            }
            Report.Text += "Percentage of Completion: " + progress.ToString();

            if(progress<20)
               Report.Text += "</br>" + "Project is currently in the Design Stage" ;
            else if (progress < 50)
                Report.Text += "</br>" + "Project is currently in the Development Stage";
            else if (progress < 70)
                Report.Text += "</br>" + "Project is currently in the Testing Stage";
            else if (progress < 100)
                Report.Text += "</br>" + "Project is currently in the Deployment Stage";

            con.Close();
        }

    }
    
}