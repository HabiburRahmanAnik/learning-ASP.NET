using LabTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LabTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String Username,string Password)
        {
            Database db = new Database();
            var user = db.Users.Login(Username, Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                //FormsAuthentication.SetAuthCookie(user.Id.ToString(), false);


                if (user.Type == 1)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    return RedirectToAction("Customer", "User");
                }
                
            }
            ViewBag.Message = "Invalid username or password";
            
            return View();
        }
    }
}