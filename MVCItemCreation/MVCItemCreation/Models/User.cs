using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCItemCreation.Models
{
    public class User
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}