using MVCCodeFirstCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirstCRUD.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserContext context;
        public ActionResult Index()
        {
            context = new UserContext();
            List<User> users = new List<User>();
            users = context.users.ToList();
            return View(users);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                context = new UserContext();
                context.users.Add(user);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}