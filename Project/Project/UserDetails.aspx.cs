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
    public partial class UserDetails : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Edit"] != null)
                {
                    lblTitle.Text = "Edit User Details";
                    lblTitle.CssClass = "form-control";
                    int UserId = int.Parse(Request.QueryString["Edit"]);
                    User user = userBO.getUserDetailsById(UserId);
                    lblNameValue.Text = user.UserName;
                    ddlRole.SelectedValue = Convert.ToString(user.Role);
                    btnEdit.Visible = true;
                    dvRole.Visible = true;
                }
                else if(Request.QueryString["Delete"] != null)
                {
                    lblTitle.Text = "Delete User";
                    lblTitle.CssClass = "form-control";
                    int UserId = int.Parse(Request.QueryString["Delete"]);
                    User user = userBO.getUserDetailsById(UserId);
                    lblNameValue.Text = user.UserName;
                    btnDelete.Visible = true;
                }
            } 
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            User user = new User(int.Parse(Request.QueryString["Edit"]), "", "", int.Parse(ddlRole.SelectedValue));
            int noOfRowsAffected = userBO.UpdateUser(user);
            if (noOfRowsAffected > 0)
            {
                Response.Write("User Updated");
            }
            else
            {
                Response.Write("Issue while updating user");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            if(Request.QueryString["Delete"] != null)
            {
                int UserId = int.Parse(Request.QueryString["Delete"]);
                int noOfRowsAffected = userBO.DeleteUser(UserId);
                if (noOfRowsAffected > 0)
                {
                    Response.Write("User Deleted");
                }
                else
                {
                    Response.Write("Issue while deleting user");
                }
            }
            
        }
    }
}