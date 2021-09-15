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
    public partial class BookDetails : System.Web.UI.Page
    {
        int BookId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            BookBO bookBO = new BookBO();
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Edit"] != null)
                {
                    lblTitle.Text = "Edit Book Details";
                    lblTitle.CssClass = "form-control";
                    BookId = int.Parse(Request.QueryString["Edit"]);
                    Book book = bookBO.getBookDetailsById(BookId);
                    lblbookName.Text = book.BookName;
                    lblbookAuthor.Text = book.Author;
                    btnEdit.Visible = true;
                }
                else if (Request.QueryString["Delete"] != null)
                {
                    lblTitle.Text = "Delete Book";
                    lblTitle.CssClass = "form-control";
                    BookId = int.Parse(Request.QueryString["Delete"]);
                    Book book = bookBO.getBookDetailsById(BookId);
                    lblbookName.Text = book.BookName;
                    lblbookAuthor.Text = book.Author;
                    btnDelete.Visible = true;
                }
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}