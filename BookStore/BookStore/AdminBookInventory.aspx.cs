using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class AdminBookInventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        static string global_filepath;
        static int global_actual_stock, global_current_stock, global_issued_books;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillAuthorPublisherValue();
            }
            Gridview1.DataBind();
        }
        //Go Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getBookById();
        }
        //Add Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkBookExits())
            {
                Response.Write("<script>alert('Book already exits, try some other book Id')</script>");
            }
            else
            {
                addNewBook();
            }
        }
        // Update button
        protected void Button5_Click(object sender, EventArgs e)
        {
            updateBookByID();
        }
        //Delete button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteBookByID();
        }
        //User defined functions
        void deleteBookByID()
        {
            if (checkBookExits())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from book_master_tbl WHERE book_id='" + TextBox2.Text.Trim() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Book Deleted Successfully');</script>");
                    Gridview1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }
        void updateBookByID()
        {

            if (checkBookExits())
            {
                try
                {
                    int actual_stock = Convert.ToInt32(TextBox7.Text.Trim());
                    int current_stock = Convert.ToInt32(TextBox8.Text.Trim());
                    if (global_actual_stock == actual_stock)
                    {

                    }
                    else
                    {
                        if (actual_stock < global_issued_books)
                        {
                            Response.Write("<script>alert('Actual Stock value cannot be less than the Issued books');</script>");
                            return;
                        }
                        else
                        {
                            current_stock = actual_stock - global_issued_books;
                            TextBox5.Text = "" + current_stock;
                        }
                    }

                    string genres = "";
                    foreach (int i in ListBox1.GetSelectedIndices())
                    {
                        genres = genres + ListBox1.Items[i] + ",";
                    }
                    genres = genres.Remove(genres.Length - 1);
                    string filepath = "~/book_inventory/books1";
                    string filename = Path.GetFileName(Fileupload1.PostedFile.FileName);
                    if (filename == "" || filename == null)
                    {
                        filepath = global_filepath;
                    }
                    else
                    {
                        Fileupload1.SaveAs(Server.MapPath("book_inventory/" + filename));
                        filepath = "~/book_inventory/" + filename;
                    }

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE book_master_tbl set booj_name=@booj_name, genre=@genre, author_name=@author_name, publisher_name=@publisher_name, publish_date=@publish_date, language=@language, edition=@edition, book_cost=@book_cost, no_of_pages=@no_of_pages, book_description=@book_description, actual_stock=@actual_stock, current_stock=@current_stock, book_img_link=@book_img_link where book_id='" + TextBox1.Text.Trim() + "'", con);
                    cmd.Parameters.AddWithValue("@booj_name", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@genre", genres);
                    cmd.Parameters.AddWithValue("@author_name", DropDownList3.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@publisher_name", DropDownList2.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@publish_date", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@language", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@edition", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@book_cost", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@no_of_pages", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@book_description", TextBox10.Text.Trim());
                    cmd.Parameters.AddWithValue("@actual_stock", actual_stock.ToString());
                    cmd.Parameters.AddWithValue("@current_stock", current_stock.ToString());
                    cmd.Parameters.AddWithValue("@book_img_link", filepath);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Gridview1.DataBind();
                    Response.Write("<script>alert('Book Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Book ID');</script>");
            }
        }
        void getBookById()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from book_master_tbl where book_id = '"+TextBox2.Text.Trim()+"'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0]["booj_name"].ToString();
                    DropDownList1.SelectedValue = dt.Rows[0]["language"].ToString();
                    DropDownList2.SelectedValue = dt.Rows[0]["publisher_name"].ToString();
                    DropDownList3.SelectedValue = dt.Rows[0]["author_name"].ToString();
                    TextBox3.Text = dt.Rows[0]["publish_date"].ToString();
                    ListBox1.ClearSelection();
                    string[] genre = dt.Rows[0]["genre"].ToString().Trim().Split(',');
                    for(int i = 0; i < genre.Length; i++)
                    {
                        for(int j = 0; j < ListBox1.Items.Count; j++)
                        {
                            if(ListBox1.Items[j].ToString() == genre[i])
                            {
                                ListBox1.Items[j].Selected = true;
                            }
                        }
                    }
                    TextBox5.Text = dt.Rows[0]["edition"].ToString();
                    TextBox6.Text = dt.Rows[0]["book_cost"].ToString().Trim();
                    TextBox4.Text = dt.Rows[0]["no_of_pages"].ToString().Trim();
                    TextBox7.Text = dt.Rows[0]["actual_stock"].ToString().Trim();
                    TextBox8.Text = dt.Rows[0]["current_stock"].ToString().Trim();
                    TextBox9.Text = ""+(Convert.ToInt32(dt.Rows[0]["actual_stock"].ToString()) - Convert.ToInt32(dt.Rows[0]["current_stock"].ToString()));
                    TextBox10.Text = dt.Rows[0]["book_description"].ToString();
                    global_actual_stock = Convert.ToInt32(dt.Rows[0]["actual_stock"].ToString().Trim());
                    global_current_stock = Convert.ToInt32(dt.Rows[0]["current_stock"].ToString().Trim());
                    global_issued_books = global_actual_stock - global_current_stock;
                    global_filepath = dt.Rows[0]["book_img_link"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Book Id')</script>"); 
                }
                
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void fillAuthorPublisherValue()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT author_name from author_master_tbl", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList3.DataSource = dt;
                DropDownList3.DataValueField = "author_name";
                DropDownList3.DataBind();
                cmd = new SqlCommand("SELECT publisher_name from publisher_master_tbl", connection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "publisher_name";
                DropDownList2.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl where book_id = '" + TextBox2.Text.Trim() + "'OR booj_name = '"+TextBox1.Text.Trim()+"' ", connection);
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
        void addNewBook()
        {
            try
            {
                string genres ="";
                foreach(int i in ListBox1.GetSelectedIndices())
                {
                    genres = genres + ListBox1.Items[i] + ",";
                }
                genres = genres.Remove(genres.Length - 1);
                string filePath = "~/book_Inventory/books1.png";
                string fileName = Path.GetFileName(Fileupload1.PostedFile.FileName);
                Fileupload1.SaveAs(Server.MapPath("book_Inventory/" + fileName));
                filePath = "~/book_Inventory/" + fileName;
                SqlConnection connection = new SqlConnection(strcon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO book_master_tbl(book_id,booj_name,genre,author_name,publisher_name,publish_date,language,edition,book_cost,no_of_pages,book_description,actual_stock,current_stock,book_img_link) values(@book_id,@booj_name,@genre,@author_name,@publisher_name,@publish_date,@language,@edition,@book_cost,@no_of_pages,@book_description,@actual_stock,@current_stock,@book_img_link)",connection);
                cmd.Parameters.AddWithValue("@book_id", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@booj_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@genre", genres);
                cmd.Parameters.AddWithValue("@author_name", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publisher_name", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publish_date", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@language", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@edition", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@book_cost", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@no_of_pages", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@book_description", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@actual_stock", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@current_stock", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@book_img_link", filePath);
                cmd.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('Book Added Successfully...');</script>");
                Gridview1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}