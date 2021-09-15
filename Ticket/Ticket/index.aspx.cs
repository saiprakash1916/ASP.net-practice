using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["name"] = Name.Text;
                Session["date"] = Date.Text;
                Session["ticket"] = Tickets.Text;
                Session["ticketType"] = ddlTicketType.Text;
                Session["event"] = ddlEventType.Text;
                Response.Redirect("Success.aspx");
            }
        }
    }
}