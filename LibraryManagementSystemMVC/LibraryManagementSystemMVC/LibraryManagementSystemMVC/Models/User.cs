using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystemMVC.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Roll { get; set; }
        public User(int userid, String username, String password, int roll)
        {
            this.UserId = userid;
            this.UserName = username;
            this.Password = password;
            this.Roll = roll;
        }

        public User()
        {
        }
    }
}