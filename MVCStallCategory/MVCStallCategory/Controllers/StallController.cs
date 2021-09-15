using MVCStallCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStallCategory.Controllers
{
    public class StallController : Controller
    {
        // GET: Stall
        StallDAO stallDAO = new StallDAO();
        public ActionResult Index()
        {
            List<Stall> stalls = stallDAO.GetAllStalls();
            return View(stalls);
        }
        public ActionResult GetStalls(string category)
        {
            List<Stall> stalls = stallDAO.GetStallsByCategory(category);
            return Json(stalls,JsonRequestBehavior.AllowGet);
        }
    }
}