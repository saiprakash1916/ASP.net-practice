using MVCSorting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSorting.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        EventBO eventBO = new EventBO();
        public ActionResult Index()
        {
            List<Event> events = eventBO.GetEvents();
            return View(events);
        }
        public ActionResult SortByName()
        {
            List<Event> events = eventBO.GetEvents().OrderBy(e => e.Name).ToList();
            return View(events);
        }
        public ActionResult SortByDate()
        {
            List<Event> events = eventBO.GetEvents().OrderBy(e => e.Date).ToList();
            return View(events);
        }
    }
}