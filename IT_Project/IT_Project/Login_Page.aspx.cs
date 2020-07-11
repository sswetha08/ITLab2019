using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace IT_Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Text = " ";
            Pwd.BackColor = System.Drawing.Color.White;

        }

        protected void LoginClick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_mgmt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT * from [Login] where UserId = @user",con);
            cmd.Parameters.AddWithValue("@user", Username.Text);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                string pass = rdr["Password"].ToString();
                string type = rdr["UserType"].ToString();

                if (String.Equals(pass, Pwd.Text))
                {
                    if (String.Equals(type, "Admin"))
                    {
                       
                        Session["userid"] = rdr["UserId"].ToString();
                        Response.Redirect("Admin_Home.aspx?name=" + rdr["Name"].ToString());
                    }
                    else if (String.Equals(type, "Dev"))
                    {
                        Session["userid"] = rdr["UserId"].ToString();
                        Response.Redirect("Dev_Home.aspx?name=" + rdr["Name"].ToString());
                       
                    }
                }
                else
                {
                    Pwd.BackColor = System.Drawing.Color.LightPink;
                    Error.Text = "Invalid Credentials!";
                }
            }
            else
            {
                Username.BackColor = System.Drawing.Color.LightPink;
                Error.Text = "Invalid Credentials!";
            }
            con.Close();
        }
    }
}