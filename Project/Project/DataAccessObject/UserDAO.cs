using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.DataAccessObject
{
    public class UserDAO
    {
        DAO dao = null;
        public UserDAO()
        {
            dao = new DAO();
        }
        public int LoginUser(User user)
        {
            int UserId = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("LoginUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@RoleId", user.Role);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    connection.Open();
                    UserId = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return UserId;
        }
        public bool DoesUserExits(string username)
        {
            bool isUserNameAlreadyPresent = false;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("DoesUserNameExits", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    connection.Open();
                    int UserId = Convert.ToInt32(command.ExecuteScalar());
                    if(UserId > 0)
                    {
                        isUserNameAlreadyPresent = true;
                    }
                    else
                    {
                        isUserNameAlreadyPresent = false;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isUserNameAlreadyPresent;
        }
        public int CreateUser(User user)
        {
            int noOfRowsAffected = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("CreateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@Password", user.Password);
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
        public User getUserDetailsById(int UserId)
        {
            User user = null;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("GetUserDetailsById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        user = new User(UserId, sdr[0].ToString(), "", Convert.ToInt32(sdr[1].ToString()));
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return user;
        }
        public int UpdateUser(User user)
        {
            int noOfRowsAffected = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("UpdateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId",user.UserId);
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
        public int DeleteUser(int UserId)
        {
            int noOfRowsAffected = 0;
            try
            {
                using (SqlConnection connection = dao.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("DeleteUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
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