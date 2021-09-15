using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCStallCRUD.Models
{
    public class StallEntity : DbContext
    {
        public StallEntity() : base("name=ConnectionString")
        {

        }
        public DbSet<Stall> Stalls { get; set; }
    }
}