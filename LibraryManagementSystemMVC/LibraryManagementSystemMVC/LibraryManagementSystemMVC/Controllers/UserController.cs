using Library_Management_System.BussinessObjects;
using LibraryManagementSystemMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace LibraryManagementSystemMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp(User user)
        {
            int NoOfRows = 0;
            UserBO userBO = new UserBO();
            if (!(userBO.UserExistOrNot(user.UserName)))
            {
                NoOfRows = userBO.InsertUser(user);
                if (NoOfRows > 0)
                {
                    ViewBag.Message = "Login Successful";
                    return RedirectToAction("Index", "User"); 
                }
            }
            else
            {
                ViewBag.Message = "Error";
                return RedirectToAction("Index", "User");
            }
                return View();
        }
        public ActionResult Login(User user)
        {
            UserBO userBO = new UserBO();
            user.UserId = userBO.UserLogin(user);
            if (user.UserId > 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                
            }
            return View();
        }
    }
}