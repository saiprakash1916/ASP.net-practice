using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstproject.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public int Gender { get; set; }
        public int UserRoll { get; set; }
    }
}