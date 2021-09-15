using Library_Management_System.DataAccessObject;
using LibraryManagementSystemMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_Management_System.BussinessObjects
{
    public class UserBO
    {
        
        public int UserLogin(User user)
        {
            UserDAO userDao = new UserDAO();
            return userDao.UserLogin(user);
        }
        public bool UserExistOrNot(String username)
        {
            UserDAO userDao = new UserDAO();
            return userDao.UserExistOrNot(username);
        }
        public int InsertUser(User user)
        {
            UserDAO userDao = new UserDAO();
            return userDao.InsertUser(user);
        }
        public User GetDetailsById(int UserId)
        {
            UserDAO userDao = new UserDAO();
            return userDao.GetDetailsById(UserId);
        }
        public int ModiifyUser(User user)
        {
            UserDAO userDao = new UserDAO();
            return userDao.ModifyUser(user);
        }
        public int DeleteUser(int UserId)
        {
            UserDAO userDao = new UserDAO();
            return userDao.DeleteUser(UserId);
        }
    }
}