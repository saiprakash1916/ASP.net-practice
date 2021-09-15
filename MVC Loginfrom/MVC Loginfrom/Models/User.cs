using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Loginfrom.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public User(int UserId,string Name,string UserName,string Password,int Role)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }

    }
}