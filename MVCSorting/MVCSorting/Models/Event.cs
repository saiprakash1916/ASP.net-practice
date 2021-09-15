using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSorting.Models
{
    public class Event
    {
		private string _name;
		private string _type;
		private DateTime _date;

		public string Name { get => _name; set => _name = value; }
		public string Type { get => _type; set => _type = value; }
		public DateTime Date { get => _date; set => _date = value; }

		public Event(string name, string type, DateTime date)
		{
			Name = name;
			Type = type;
			Date = date;
		}
		public Event()
		{
		}
	}
}