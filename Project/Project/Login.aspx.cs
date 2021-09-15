using Project.BusinessObject;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            string userName = txtName.Text;
            string password = txtPass.Text;
            int role = Convert.ToInt32(ddlRole.SelectedValue);
            User user = new User(0,userName,password,role);
            user.UserId = userBO.LoginUser(user);
            if(user.UserId > 0)
            {
                Session["UserDetails"] = user;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("Invaild username and password");
            }
        }
    }
}