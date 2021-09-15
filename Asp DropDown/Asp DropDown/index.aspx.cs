using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_DropDown
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TicketType_Change(object sender, EventArgs e)
        {
            int NoOfTicket = Convert.ToInt32(TicketNumber.Text);
            int amount;
            int Ttype = Convert.ToInt32(TicketType.SelectedValue);
            if (Ttype == 1)
            {
                int Platinum = 250;
                amount = Convert.ToInt32(NoOfTicket * Platinum);
            }
            if (Ttype == 2)
            {
                int Gold = 200;
                amount = Convert.ToInt32(NoOfTicket * Gold);
            }
            else
            {
                int Silver = 150;
                amount = Convert.ToInt32(NoOfTicket * Silver);
            }
        }
    }
}