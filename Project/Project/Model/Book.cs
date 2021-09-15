using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string isBookAvailable { get; set; }
        public Book(int BookId,string BookName,string Author,string isBookAvailable)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.Author = Author;
            this.isBookAvailable = isBookAvailable;
        }
    }
}