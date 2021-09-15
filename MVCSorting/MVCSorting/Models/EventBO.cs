using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSorting.Models
{
    public class EventBO
    {
		public List<Event> GetEvents()
		{
			List<Event> events = new List<Event>();
			events.Add(new Event("Sky Lantern Festival", "Stage Event", new DateTime(2020, 05, 01)));
			events.Add(new Event("Rio Carnival", "Exhibition", new DateTime(2020, 04, 20)));
			events.Add(new Event("Songkran", "Exhibition", new DateTime(2020, 04, 25)));
			events.Add(new Event("Stars of the white house", "Stage Event", new DateTime(2020, 05, 15)));
			events.Add(new Event("Cannes film festival", "Stage Event", new DateTime(2020, 04, 19)));
			events.Add(new Event("Glastonbury", "Exhibition", new DateTime(2020, 03, 30)));
			events.Add(new Event("Tomorrowland", "Exhibition", new DateTime(2020, 04, 24)));
			events.Add(new Event("TrickEye", "Exhibition", new DateTime(2020, 04, 30)));
			events.Add(new Event("Comic con International", "Stage Event", new DateTime(2020, 05, 05)));
			return events;
		}
	}
}