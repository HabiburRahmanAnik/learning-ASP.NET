using LabTask.Auth;
using LabTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.Controllers
{
    public class OrderController : Controller
    {
        [Authorize]
        // GET: Order
        public ActionResult MyOrder()
        {
            Database db = new Database();
            var myOrder = db.Orders.MyOrder();
            return View(myOrder);
        }
    }
}