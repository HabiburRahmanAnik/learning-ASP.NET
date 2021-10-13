using LabTask.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.Controllers
{
    [UserAccess]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
       
        
    }
}