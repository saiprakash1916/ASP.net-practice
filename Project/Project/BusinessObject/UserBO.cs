using Project.DataAccessObject;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessObject
{
    public class UserBO
    {
        public int LoginUser(User user)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.LoginUser(user);
        }
        public bool DoesUserExits(string username)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.DoesUserExits(username);
        }
        public int CreateUser(User user)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.CreateUser(user);
        }
        public User getUserDetailsById(int UserId)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.getUserDetailsById(UserId);
        }
        public int UpdateUser(User user)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.UpdateUser(user);
        }
        public int DeleteUser(int UserId)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.DeleteUser(UserId);
        }
    }
}