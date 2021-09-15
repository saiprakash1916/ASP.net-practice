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
    public partial class AdminMember : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Gridview1.DataBind();
        }
        //Go Button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getMemberById();
        }
        //Active Button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateMemberStatusById("Active");
        }
        //Pending Button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateMemberStatusById("Pending");
        }
        //Deactive Button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateMemberStatusById("Deactive");
        }
        //Delete Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMemberById();
        }
        //user define function
        void getMemberById()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl where menber_id = '" + TextBox2.Text.Trim() + "' ", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TextBox1.Text = dr.GetValue(0).ToString();
                        TextBox7.Text = dr.GetValue(10).ToString();
                        TextBox3.Text = dr.GetValue(1).ToString();
                        TextBox4.Text = dr.GetValue(2).ToString();
                        TextBox8.Text = dr.GetValue(3).ToString();
                        TextBox9.Text = dr.GetValue(4).ToString();
                        TextBox10.Text = dr.GetValue(5).ToString();
                        TextBox11.Text = dr.GetValue(6).ToString();
                        TextBox5.Text = dr.GetValue(7).ToString();
                    }
                }
                else
                {
                    Response.Write("<script>alert('Inavalid Id')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateMemberStatusById(string status)
        {
            if (checkMemberExits())
            {
                try
                {
                    SqlConnection connection = new SqlConnection(strcon);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE member_master_tbl SET account_status = '" + status + "' where menber_id = '" + TextBox2.Text.Trim() + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Gridview1.DataBind();
                    Response.Write("<script>alert('Member status Updated');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid member ID');</script>");
            }
        }
        void deleteMemberById()
        {
            if (checkMemberExits())
            {
                try
                {
                    SqlConnection connection = new SqlConnection(strcon);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand("DELETE from member_master_tbl where menber_id = '" + TextBox2.Text.Trim() + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Response.Write("<script>alert('Member Deleted successfully...');</script>");
                    clearForm();
                    Gridview1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                } 
            }
            else
            {
                Response.Write("<script>alert('Invalid member ID');</script>");
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl where menber_id = '" + TextBox2.Text.Trim() + "' ", connection);
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
            TextBox7.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox5.Text = "";
        }
    }
}