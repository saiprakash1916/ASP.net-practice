using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserDetails"] != null)
            {
                int role = ((User)Session["UserDetails"]).Role;
                if(role != 1)
                {
                    Response.Redirect("PageNotFound.aspx");
                }
            }
        }
    }
}