using MVCHallSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHallSearch.Controllers
{
    public class HallController : Controller
    {
        // GET: Hall
        HallBO hallBO = new HallBO();
        public ActionResult Index()
        {
            var search = Convert.ToString(hallBO);
            List<Hall> halls = hallBO.GetHalls();
            return View(halls);
        }
    }
}