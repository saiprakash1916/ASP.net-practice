using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class AdminBookIssueing : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Gridview1.DataBind();
        }
        //Go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getNames();
        }
        //Issue button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if(checkBookExits() && checkMemberExits())
            {
                if (checkIssueEntryExits())
                {
                    Response.Write("<script>alert('This member already has this book');</script>");
                }
                else
                {
                    issueBook();
                }
            }
            else
            {
                Response.Write("<script>alert('Wrong book id or member id');</script>");
            }
        }
        //Return button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkBookExits() && checkMemberExits())
            { 
                if (checkIssueEntryExits())
                {
                    returnBook();
                }
                else
                {
                    Response.Write("<script>alert('This entry does not exits');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Wrong book id or member id');</script>");
            }
        }
        //user defined function
        void returnBook()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE from book_issue_tbl where book_id = '"+TextBox1.Text.Trim()+ " And member_id = '"+TextBox2.Text.Trim()+"'')", connection);
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    cmd = new SqlCommand("UPDATE book_master_tbl set current_stock = current_stock+1 where book_id = '" + TextBox1.Text.Trim() + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Response.Write("<script>alert('Member returned Successfully...');</script>");
                    Gridview1.DataBind();
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
        bool checkIssueEntryExits()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from book_issue_tbl where member_id = '" + TextBox2.Text.Trim() + "'AND book_id = '"+TextBox1.Text.Trim()+"' ", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            return false;
        }
        void issueBook()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into book_issue_tbl (member_id,member_name,book_id,book_name,issue_date,due_date) values (@member_id,@member_name,@book_id,@book_name,@issue_date,@due_date)", connection);
                cmd.Parameters.AddWithValue("@member_id", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@member_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@book_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@issue_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@due_date", TextBox6.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("UPDATE book_master_tbl set current_stock = current_stock -1 where book_id = '" + TextBox1.Text.Trim() + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Book Issued Successfully...');</script>");
                Gridview1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkBookExits()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from book_master_tbl where book_id = '" + TextBox1.Text.Trim() + "'AND current_stock >0", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        bool checkMemberExits()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl where menber_id = '" + TextBox2.Text.Trim() + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void getNames()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT booj_name from book_master_tbl where book_id = '" + TextBox1.Text.Trim() + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox4.Text = dt.Rows[0]["booj_name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Wrong Book Id');</script>");
                }
                cmd = new SqlCommand("SELECT full_name from member_master_tbl where menber_id = '" + TextBox2.Text.Trim() + "'", connection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox3.Text = dt.Rows[0]["full_name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Wrong Member Id');</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"');</script>");
            }
        }

        protected void Gridview1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if(e.Row.RowType == DataControlRowType.DataRow)
                {
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime today = DateTime.Today;
                    if(today > dt)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}