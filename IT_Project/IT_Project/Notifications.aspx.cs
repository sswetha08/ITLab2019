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
    public partial class Notifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "approve")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Project_mgmt; Integrated Security=true;Pooling=false";

                SqlCommand cmd = new SqlCommand("update Comments set ReviewStatus=@reviewstatus where CommentId=@commentid", con);
                cmd.Parameters.AddWithValue("@reviewstatus", "Approved");
                cmd.Parameters.AddWithValue("@commentid", e.CommandArgument.ToString());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception err)
                {
                    System.Diagnostics.Debug.WriteLine("error " + err.Message);
                }
                finally
                {
                    con.Close();
                }
                
                gv.DataBind();

            }
            else if (e.CommandName == "reject")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Project_mgmt; Integrated Security=true;Pooling=false";


                SqlCommand cmd = new SqlCommand("update Comments set ReviewStatus=@reviewstatus where CommentId=@commentid", con);
                cmd.Parameters.AddWithValue("@reviewstatus", "Rejected");
                cmd.Parameters.AddWithValue("@commentid", e.CommandArgument.ToString());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    System.Diagnostics.Debug.WriteLine("error " + err.Message);
                }
                finally
                {
                    con.Close();
                }
                gv.DataBind();
            }
        }
    }
}