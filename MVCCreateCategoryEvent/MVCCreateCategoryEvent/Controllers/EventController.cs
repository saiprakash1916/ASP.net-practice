using MVCCreateCategoryEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCreateCategoryEvent.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListEventCatagories()
        {
            List<Event> events = new List<Event>();
            EventBo eventBo = new EventBo();
            events = eventBo.GetAllEvents();
            return PartialView("_ListEventCategories",events);
        }
        public PartialViewResult Save(Event @event)
        {
            List<Event> events = new List<Event>();
            EventBo eventBo = new EventBo();
            eventBo.CreateEvent(@event);
            events = eventBo.GetAllEvents();
            return PartialView("_ListEventCategories", events);
        }
    }
}