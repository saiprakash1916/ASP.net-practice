using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStallCategory.Models
{
    public class Stall
    {
        int _id;
        string _name;
        string _mobile;
        string _category;
        string _owner;

        public Stall()
        {
        }

        public Stall(int id, string name, string mobile, string category, string owner)
        {
            Id = id;
            Name = name;
            Mobile = mobile;
            Category = category;
            Owner = owner;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string Category { get => _category; set => _category = value; }
        public string Owner { get => _owner; set => _owner = value; }
    }
}