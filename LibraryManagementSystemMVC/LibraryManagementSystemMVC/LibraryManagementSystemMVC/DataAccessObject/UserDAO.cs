using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using LibraryManagementSystemMVC.Models;

namespace Library_Management_System.DataAccessObject
{
    public class UserDAO
    {
        DAO dao = null;
        public UserDAO()
        {
            dao = new DAO();
        }
        public int UserLogin(User user)
        {
            int UserId = 0;
            try { 
            using (SqlConnection connection = dao.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("UserLogin", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName",user.UserName);
                command.Parameters.AddWithValue("@RoleId", user.Roll);
                command.Parameters.AddWithValue("@Password", user.Password);
                connection.Open();
                UserId = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return UserId;
        }
        public bool UserExistOrNot(String username)
        {
            int UserId = 0;
            bool UserAlreadyExist = false;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("DoesUserExist", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    connection.Open();
                     UserId= Convert.ToInt32(command.ExecuteScalar());
                    if (UserId > 0)
                    {
                        UserAlreadyExist = true;
                    }
                    else
                    {
                        UserAlreadyExist = false;
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return UserAlreadyExist;
        }
        public int InsertUser(User user)
        {
            int NoOfRows = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("AddUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@RollId", user.Roll);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    connection.Open();
                    NoOfRows = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return NoOfRows;
        }

        public User GetDetailsById(int UserId)
        {
            User user = null;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("GetUserDetailById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        user = new User(UserId,sdr[0].ToString(),"",Convert.ToInt32(sdr[1].ToString()));
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user;
        }

        public int ModifyUser(User user)
        {
            int NoOfRowsAffect = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("UpdateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    command.Parameters.AddWithValue("@Role", user.Roll);
                    connection.Open();
                    NoOfRowsAffect = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return NoOfRowsAffect;
        }
        public int DeleteUser(int UserId)
        {
            int NoOfRowsAffect = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("DeleteUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
                    connection.Open();
                    NoOfRowsAffect = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return NoOfRowsAffect;
        }

    }
}