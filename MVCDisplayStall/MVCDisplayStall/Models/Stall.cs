using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDisplayStall.Models
{
    public class Stall
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Stall() { }
        public Stall(string Name, string Type)
        {
            this.Name = Name;
            this.Type = Type;
        }
    }
}