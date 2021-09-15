using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Registation
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblValueName.Text = Convert.ToString(Session["name"]);
            lblValueUsername.Text = Convert.ToString(Session["username"]);
            lblValuePassword.Text = Convert.ToString(Session["password"]);
        }
    }
}