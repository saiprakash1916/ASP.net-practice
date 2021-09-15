using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class UserProfile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                /*if(Session["username"].ToString() =="" || Session["username"].ToString() == null)
                {
                    Response.Write("<script>alert('Session is exparied please login again')</script>");
                    Response.Redirect("UserProfile.aspx");
                }
                else
                {
                    getUserBookData();
                }*/
            }
            catch(Exception ex)
            {
                         
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        //Update button
        protected void Button1_Click(object sender, EventArgs e)
        {
            //getUserData();
        }
        // user defined function
        void getUserBookData()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * book_issue_tbl where menber_id = '" + Session["username"].ToString() + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Gridview1.DataSource = dt;
                Gridview1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Gridview1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime today = DateTime.Today;
                    if (today > dt)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}