using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAjaxEditEvent.Models;

namespace MVCAjaxEditEvent.Controllers
{
    public class EventsController : Controller
    {
        private EventEntity db = new EventEntity();

        // GET: Events
        public ActionResult Index()
        {
            return View(db.events.ToList());
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EventName,Detail,EventType,EventOrganizerName")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
