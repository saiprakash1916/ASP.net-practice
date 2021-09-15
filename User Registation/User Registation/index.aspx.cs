using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Registation
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
                Session["username"] = Username.Text;
                Session["password"] = Password.Text;
                Session["confirmPassword"] = ConfirmPassword.Text;
                Response.Redirect("Success.aspx");
            }
        }
    }
}