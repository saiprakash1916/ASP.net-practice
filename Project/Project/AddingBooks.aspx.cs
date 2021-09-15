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
    public partial class AddingBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {
                int role = ((User)Session["UserDetails"]).Role;
                if (role != 2)
                {
                    Response.Redirect("PageNotFound.aspx");
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            BookBO bookBo = new BookBO();
            string bookName = txtbookName.Text;
            string authorName = txtbookAuthor.Text;
            string isAvailable = isBookAvailable.SelectedValue;
            Book book = new Book(0,bookName,authorName, isAvailable);
            if (!bookBo.DoesBookExits(bookName))
            {
                int noOfRowsAffected = bookBo.AddBook(book);
                if (noOfRowsAffected > 0)
                {
                    Response.Write("Book is Added");
                }
                else
                {
                    Response.Write("Some error while adding the book");
                }
            }
            else
            {
                Response.Write("Book already exit");
            }
        }
    }
}