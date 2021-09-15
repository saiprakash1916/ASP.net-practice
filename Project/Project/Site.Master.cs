using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string name = ((User)Session["UserDetails"]).UserName;
                lblGreetUser.Text = "Hi " + name; 
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
}