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
    public partial class AdminAuthorManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Gridview1.DataBind();
        }
        //Add Button Click
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkAuthorExits())
            {
                Response.Write("<script>alert('Author with this ID already Exits. You cannot add another author with the same author Id');</script>");
            }
            else
            {
                addNewAuthor();
            }
        }
        //Update Button Click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkAuthorExits())
            {
                updateAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author Does not Exits');</script>");
            }
        }
        //Delete Button Click
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkAuthorExits())
            {
                deleteAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author Does not Exits');</script>");
            }
        }
        //Go Button Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getAuthorByID();
        }
        // User defined function
        void getAuthorByID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl where author_id = '" + TextBox1.Text.Trim() + "' ", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Author ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteAuthor()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE from author_master_tbl where author_id = '" + TextBox1.Text.Trim() + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Author Deleted successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateAuthor()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE author_master_tbl SET author_name = @author_name where author_id = '"+TextBox1.Text.Trim()+"'", connection);
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Author Updated successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void addNewAuthor()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO author_master_tbl (author_id,author_name) values(@author_id,@author_name)", connection);
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Author added successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkAuthorExits()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl where author_id = '" + TextBox1.Text.Trim() + "' ", connection);
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
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}