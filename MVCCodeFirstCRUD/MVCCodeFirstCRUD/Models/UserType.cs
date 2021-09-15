using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirstCRUD.Models
{
    public class UserType
    {
        [Key]
        [Required]
        public int UserTypeId { get; set; }
        [Required]
        public string UserTypeName { get; set; }
    }
}