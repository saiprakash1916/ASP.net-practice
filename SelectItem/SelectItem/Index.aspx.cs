using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelectItem
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["name"].Text;
            selectedItem.Text = "Your selected item" + name;
        }

        protected void Projector_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        protected void Table_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        protected void Balloon_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        protected void Candle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        protected void Radio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        protected void Pen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }
    }
}