using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirstCRUD.Models
{
    public class UserContext:DbContext
    {
        public UserContext() : base("name=ConnectionString")
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<UserType> userTypes { get; set; }
    }
}