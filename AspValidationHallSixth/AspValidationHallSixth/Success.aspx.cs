using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspValidationHallSixth
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNameValue.Text = Convert.ToString(Session["name"]);
            lblEmailValue.Text = Convert.ToString(Session["email"]);
            lblMobileValue.Text = Convert.ToString(Session["mobileNumber"]);
            lblHallName.Text = Convert.ToString(Session["hallName"]);
        }
    }
}