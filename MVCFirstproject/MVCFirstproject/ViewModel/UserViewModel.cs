using MVCFirstproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstproject.ViewModel
{
    public class UserViewModel
    {
        public User user { get; set; }
        public Usertype usertype { get; set; }
    }
}