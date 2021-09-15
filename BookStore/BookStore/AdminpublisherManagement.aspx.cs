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
    public partial class AdminpublisherManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Gridview1.DataBind();
        }
        // Adding details by button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkPublisherExits())
            {
                Response.Write("<script>alert('Publisher with this ID already Exits. You cannot add another Publisher with the same Publisher Id');</script>");
            }
            else
            {
                addPublisher();
            }
        }
        // Updateing details by button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkPublisherExits())
            {
                updatePublisher();
            }
            else
            {
                Response.Write("<script>alert('Publisher Does not Exits');</script>");
            }
        }
        // Deleting details by button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkPublisherExits())
            {
                deletePublisher();
            }
            else
            {
                Response.Write("<script>alert('Publisher Does not Exits');</script>");
            }
        }
        // Searching details by button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getPublisherByID();
        }
        // user defined code
        bool checkPublisherExits()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_tbl where publisher_id = '" + TextBox1.Text.Trim() + "' ", connection);
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
        void addPublisher()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO publisher_master_tbl (publisher_id,publisher_name) values(@publisher_id,@publisher_name)", connection);
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Publisher added successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updatePublisher()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE publisher_master_tbl SET publisher_name = @publisher_name where publisher_id = '" + TextBox1.Text.Trim() + "'", connection);
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Publisher Updated successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deletePublisher()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE from publisher_master_tbl where publisher_id = '" + TextBox1.Text.Trim() + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Publisher Deleted successfully...');</script>");
                clearForm();
                Gridview1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void getPublisherByID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_tbl where publisher_id = '" + TextBox1.Text.Trim() + "' ", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Publisher ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}