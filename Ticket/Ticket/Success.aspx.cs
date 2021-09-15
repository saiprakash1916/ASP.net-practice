using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblValueName.Text = Convert.ToString(Session["name"]);
            lblValueDate.Text = Convert.ToString(Session["date"]);
            lblValueNumberofTickets.Text = Convert.ToString(Session["ticket"]);
            lblValueTicketType.Text = Convert.ToString(Session["ticketType"]);
            lblvalueEvent.Text = Convert.ToString(Session["event"]);
        }
    }
}