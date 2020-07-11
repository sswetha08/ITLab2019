using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Project
{
    public partial class Dev_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Welcome_msg_label.Text = "Welcome back " + Request.QueryString["name"]+"!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProject.aspx?name=" + Request.QueryString["name"] + "&userid=" + Session["userid"].ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MakeComments.aspx?name="+ Request.QueryString["name"] + "&userid=" + Session["userid"].ToString());
        }
    }
}