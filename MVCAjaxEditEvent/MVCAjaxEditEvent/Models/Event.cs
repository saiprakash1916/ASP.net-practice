using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAjaxEditEvent.Models
{
    public class Event
    {
        int _id;
        string _eventName;
        string _detail;
        string _eventType;
        string _eventOrganizerName;

        public Event()
        {
        }

        public Event(int id, string eventName, string detail, string eventType, string eventOrganizerName)
        {
            Id = id;
            EventName = eventName;
            Detail = detail;
            EventType = eventType;
            EventOrganizerName = eventOrganizerName;
        }

        public int Id { get => _id; set => _id = value; }
        public string EventName { get => _eventName; set => _eventName = value; }
        public string Detail { get => _detail; set => _detail = value; }
        public string EventType { get => _eventType; set => _eventType = value; }
        public string EventOrganizerName { get => _eventOrganizerName; set => _eventOrganizerName = value; }
    }
}
