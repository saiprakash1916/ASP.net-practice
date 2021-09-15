using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRent.Models
{
    public class Rent
    {
        public string Name { get; set; }
        public string HallOwner { get; set; }
        public int CostPerDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}