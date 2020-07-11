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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected int n;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlQuery="select count(*) from [Comments] where ReviewStatus='Pending'";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=Project_mgmt;Integrated Security=SSPI";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            try
            {
                con.Open();
                n = (int)cmd.ExecuteScalar();
                this.DataBind();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}