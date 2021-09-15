using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspValidationHallSixth
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["name"] = name.Text;
                Session["email"] = email.Text;
                Session["mobileNumber"] = mobileNumber.Text;
                Session["hallName"] = hallName.Text;
                Response.Redirect("Success.aspx");
            }
        }
    }
}