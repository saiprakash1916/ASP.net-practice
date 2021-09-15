using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.DataAccessObject
{
    public class BookDAO
    {
        DAOBook bookDAO = null;
        public BookDAO()
        {
            bookDAO = new DAOBook();
        }
        public int AddBook(Book book)
        {
            int noOfRowsAffected = 0;
            try
            {
                using (SqlConnection connection = bookDAO.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("AddBook", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookName", book.BookName);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    connection.Open();
                    noOfRowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return noOfRowsAffected;
        }
        public bool DoesBookExits(string bookName)
        {
            bool isBookNameAlreadyPresent = false;
            try
            {
                using (SqlConnection connection = bookDAO.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("DoesBookNameExits", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookName", bookName);
                    connection.Open();
                    int UserId = Convert.ToInt32(command.ExecuteScalar());
                    if (UserId > 0)
                    {
                        isBookNameAlreadyPresent = true;
                    }
                    else
                    {
                        isBookNameAlreadyPresent = false;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isBookNameAlreadyPresent;
        }
        public Book getBookDetailsById(int BookId)
        {
            Book book = null;
            try
            {
                using (SqlConnection connection = bookDAO.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("GetBookDetailsById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookId", BookId);
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        book = new Book(BookId, sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString()); 
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return book;
        }
    }
}