using MVCFirstproject.Models;
using MVCFirstproject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstproject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display(User user)
        {
            /*User user = new User();
            user.Name = form["Name"];
            user.Username = form["UserName"];
            user.Gender = form["Gender"] == "Male"?1:0;
            Usertype usertype = new Usertype();
            usertype.UserTypeId = int.Parse(form["UserType"]);
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.user = user;
            userViewModel.usertype = usertype;*/
            //ViewData["UserDetails"] = user;
            //ViewBag.User = user;
            //TempData["UserDetails"] = user;
            return View(user);
        }
    }
}