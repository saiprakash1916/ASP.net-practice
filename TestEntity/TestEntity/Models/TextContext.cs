using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestEntity.Models
{
    public class TextContext:DbContext
    {
        public TextContext() : base("name=ConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}