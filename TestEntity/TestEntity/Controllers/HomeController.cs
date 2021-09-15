using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestEntity.Models;

namespace TestEntity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*TextContext textContext = new TextContext();
            Role role = new Role() { RoleId = 1, RoleName = "Admin" };
            textContext.Roles.Add(role);
            textContext.SaveChanges();
            User user = new User() { UserName = "saiprakash", Gender = "Male", Password = "saiprakash", RoleId = 1 };
            textContext.Users.Add(user);
            textContext.SaveChanges();*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}