using JqueryNotification.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryNotification.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactViewModel objcontactViewModel)
        {
            return Json(data: new { success = true, message = "Your request has been successfully added..." },JsonRequestBehavior.AllowGet);
        }
    }
}