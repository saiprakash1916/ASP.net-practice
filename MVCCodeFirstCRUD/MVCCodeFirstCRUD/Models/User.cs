using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirstCRUD.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Gender {get;set;}
        [Required]
        public int UserTypeId { get; set; }
    }
}