using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStallCRUD.Models
{
    public class Stall
    {
        [Key]
        public int Id { get; set; }
        public string StallName { get; set; }
        public string Details { get; set; }
        public Stall() { }
        public Stall (int Id,string StallName,string Details)
        {
            this.Id = Id;
            this.StallName = StallName;
            this.Details = Details;
        }
    }
}