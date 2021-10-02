using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protfolio.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Bio()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult PersonalInfo()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Reffrence()
        {
            return View();
        }
    }
}