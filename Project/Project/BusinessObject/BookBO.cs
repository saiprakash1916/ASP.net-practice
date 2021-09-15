using Project.DataAccessObject;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessObject
{
    public class BookBO
    {
        public int AddBook(Book book)
        {
            BookDAO bookDAO = new BookDAO();
            return bookDAO.AddBook(book);
        }
        public bool DoesBookExits(string bookname)
        {
            BookDAO bookDAO = new BookDAO();
            return bookDAO.DoesBookExits(bookname);
        }
        public Book getBookDetailsById(int BookId)
        {
            BookDAO bookDAO = new BookDAO();
            return bookDAO.getBookDetailsById(BookId);
        }
    }
}