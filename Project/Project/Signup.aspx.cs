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
    public partial class Signup : System.Web.UI.Page
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
            User user = new User(0, userName, password, role);
            if (!userBO.DoesUserExits(userName))
            {
                int noOfRowsAffected = userBO.CreateUser(user);
                if(noOfRowsAffected > 0)
                {
                    Response.Write("User created");
                }
                else
                {
                    Response.Write("Some error while entering user");
                }
            }
            else
            {
                Response.Write("Username already exit");
            }
        }
    }
}