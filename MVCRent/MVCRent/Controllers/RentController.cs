using MVCRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRent.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate(Rent rent)
        {

            TimeSpan ts = (rent.EndDate - rent.StartDate);
            var t = 0.0;
            if (rent.StartDate == rent.EndDate)
            {
                t = 1;
            }
            else
            {
                t = ts.TotalDays;
            }

            TempData["HallDetail"] = rent;
            TempData["TotalCost"] = (rent.CostPerDay * t);
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}