using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_User
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            Name.Text = Convert.ToString(Session["name"]);
            Email.Text = Convert.ToString(Session["email"]);
            Phone.Text = Convert.ToString(Session["phone"]);
            Location.Text = Convert.ToString(Session["location"]);
            Gender.Text = Convert.ToString(Session["gender"]);
            Language.Text = Convert.ToString(Session["languages"]);
            Membership.Text = Convert.ToString(Session["member"]);
        }
    }
}