using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEntity.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public Role Role { get; set; }
    }
}