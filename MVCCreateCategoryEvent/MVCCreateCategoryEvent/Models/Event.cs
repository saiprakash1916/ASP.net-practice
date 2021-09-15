using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCreateCategoryEvent.Models
{
    public class Event
    {
        private int _id;
        private string _name;
        private string _type;
        private string _organizer;

        //Fill your code here
        public int Id { get => _id; set => _id = value; }

        //Fill your code here
        public string Name { get => _name; set => _name = value; }

        //Fill your code here
        public string Type { get => _type; set => _type = value; }

        //Fill your code heres
        public string Organizer { get => _organizer; set => _organizer = value; }

        public Event() { }

        public Event(int id, string name, string type, string organizer)
        {
            Id = id;
            Name = name;
            Type = type;
            Organizer = organizer;
        }
    }
}