using MVC_Loginfrom.DataAccessObject;
using MVC_Loginfrom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Loginfrom.BusinessObject
{
    public class UserBO
    {
        public int CreateUser(User user)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.CreateUser(user);
        }
    }
}