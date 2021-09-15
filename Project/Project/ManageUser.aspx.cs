using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class ManageUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {
                int role = ((User)Session["UserDetails"]).Role;
                if (!(role== 1||role==2))
                {
                    Response.Redirect("PageNotFound.aspx");
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "EditUser")
            {
                Response.Redirect("UserDetails.aspx?Edit=" + e.CommandArgument);
            }
            else if (e.CommandName == "DeleteUser")
            {
                Response.Redirect("UserDetails.aspx?Delete=" + e.CommandArgument);
            }
            else
            {
                return;
            }
        }
    }
}