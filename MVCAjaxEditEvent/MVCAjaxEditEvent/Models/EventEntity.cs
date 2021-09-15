using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAjaxEditEvent.Models
{
    public class EventEntity:DbContext
    {
        public EventEntity() : base("name=ConnectionString")
        {

        }
        public DbSet<Event> events { get; set; }
    }
}