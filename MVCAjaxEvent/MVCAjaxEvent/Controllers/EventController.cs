using MVCAjaxEvent.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxEvent.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RetrieveXml()
        {
            string url = "https://app.e-box.co.in/uploads/EventList.xml";
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(url);
            List<Event> events = new List<Event>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                events.Add(new Event() { eventName = dataRow["Event Name"].ToString(), enentDetails = dataRow["Enent Details"].ToString(), eventType = dataRow["Event Type"].ToString(), eventOrganizerName = dataRow["Event Organizer Name"].ToString() });
            }
            return View(events);
        }
    }
}