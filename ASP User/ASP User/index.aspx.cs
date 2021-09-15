using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_User
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["name"] = Name.Text;
                Session["email"] = Email.Text;
                Session["phone"] = Phone.Text;
                Session["location"] = Location.Text;
                Session["gender"] = gender.SelectedValue;
                Session["languages"] = languages.SelectedItem;
                Session["member"] = Membership.SelectedItem;
                Response.Redirect("Display.aspx");
            }
        }
    }
}