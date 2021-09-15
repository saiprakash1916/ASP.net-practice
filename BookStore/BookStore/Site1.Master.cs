using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true; // user login link button
                    LinkButton2.Visible = true; // user signup link button
                    LinkButton3.Visible = false; // logout link button
                    LinkButton5.Visible = false; //  hello user  link button
                    LinkButton6.Visible = true;  //admin login
                    LinkButton11.Visible = false; //author management link
                    LinkButton12.Visible = false; //publisher management link
                    LinkButton8.Visible = false; //book inventory link
                    LinkButton9.Visible = false; //book issueing link
                    LinkButton10.Visible = false; //member management link
                }
                else if(Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // user signup link button
                    LinkButton3.Visible = true; // logout link button
                    LinkButton5.Visible = true; //  hello user  link button
                    LinkButton5.Text ="Hello "+ Session["username"].ToString();
                    LinkButton6.Visible = true;  //admin login
                    LinkButton11.Visible = false; //author management link
                    LinkButton12.Visible = false; //publisher management link
                    LinkButton8.Visible = false; //book inventory link
                    LinkButton9.Visible = false; //book issueing link
                    LinkButton10.Visible = false; //member management link
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // user signup link button
                    LinkButton3.Visible = true; // logout link button
                    LinkButton5.Visible = true; //  hello user  link button
                    LinkButton5.Text = "Hello Admin";
                    LinkButton6.Visible = false;  //admin login
                    LinkButton11.Visible = true; //author management link
                    LinkButton12.Visible = true; //publisher management link
                    LinkButton8.Visible = true; //book inventory link
                    LinkButton9.Visible = true; //book issueing link
                    LinkButton10.Visible = true; //member management link
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAuthorManagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminpublisherManagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookInventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookIssueing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMember.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignUp.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBook.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton1.Visible = true; // user login link button
            LinkButton2.Visible = true; // user signup link button
            LinkButton3.Visible = false; // logout link button
            LinkButton5.Visible = false; //  hello user  link button
            LinkButton6.Visible = true;  //admin login
            LinkButton11.Visible = false; //author management link
            LinkButton12.Visible = false; //publisher management link
            LinkButton8.Visible = false; //book inventory link
            LinkButton9.Visible = false; //book issueing link
            LinkButton10.Visible = false; //member management link
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
            
        }
    }
}