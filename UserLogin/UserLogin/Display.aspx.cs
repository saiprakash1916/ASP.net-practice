using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLogin
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Book_Event(object sender, EventArgs e)
        {
            String Name = Convert.ToString(Session["Name"]);
            if (Name == "Customer")
            {
                Response.Redirect("Action.aspx");
            }
            else
            {
                Response.Redirect("NoAccess.aspx");
            }
        }

        protected void Create_Event(object sender, EventArgs e)
        {
            String Name = Convert.ToString(Session["Name"]);
            if (Name == "EventOwner")
            {
                Response.Redirect("Action.aspx");
            }
            else
            {
                Response.Redirect("NoAccess.aspx");
            }
        }

        protected void Add_Item(object sender, EventArgs e)
        {
            String Name = Convert.ToString(Session["Name"]);
            if (Name == "StallOwner")
            {
                Response.Redirect("Action.aspx");
            }
            else
            {
                Response.Redirect("NoAccess.aspx");
            }
        }

        protected void Allocate_Hall(object sender, EventArgs e)
        {
            String Name = Convert.ToString(Session["Name"]);
            if (Name == "HallOwner")
            {
                Response.Redirect("Action.aspx");
            }
            else
            {
                Response.Redirect("NoAccess.aspx");
            }
        }
    }
}