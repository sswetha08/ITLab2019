using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace IT_Project
{
    public partial class DisplayStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("SELECT Title from [Project] ", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    DropDownList1.Items.Add(rdr["Title"].ToString());
                }
                con.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        protected void Clicked(object sender,EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT * from [Project] where Title = @title", con);
           cmd.Parameters.AddWithValue("@title", DropDownList1.SelectedValue);
            con.Open();
            
            SqlDataReader rd = cmd.ExecuteReader();
           
            while (rd.Read())
            {
                PId.Text = "ID:" + rd["PId"].ToString();
                PClient.Text = "Client:" + rd["Client"].ToString();
                PDuration.Text = "Duration (in months) : "+ rd["DurationMonths"].ToString();
                PStatus.Text = "Completion Status: " +  rd["Status"].ToString();
            }
            
            con.Close();

        }
    }
}