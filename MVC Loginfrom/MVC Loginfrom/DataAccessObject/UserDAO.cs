using MVC_Loginfrom.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Loginfrom.DataAccessObject
{
    public class UserDAO
    {
        DAO dao = null;
        public UserDAO()
        {
            dao = new DAO();
        }
        public int CreateUser(User user)
        {
            int noOfRowsAffected = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("NewUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@UserName", user.UserName);   
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);
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
    }
}