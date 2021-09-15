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
    public partial class Userlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //User Login
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl where menber_id = '"+TextBox1.Text.Trim()+ "' and password = '"+TextBox2.Text.Trim()+"'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Login Successfully...');</script>");
                        Session["username"] = dr.GetValue(8).ToString();
                        Session["fullname"] = dr.GetValue(0).ToString();
                        Session["role"] = "user";
                        Session["status"] = dr.GetValue(10).ToString();
                    }
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Details');</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}