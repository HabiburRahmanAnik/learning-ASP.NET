using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask.Models;
using LabTask.Models.Entity;

namespace LabTask.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Database db = new Database();
            var productList= db.Products.GetAllProducts();
            return View(productList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.AddProduct(p);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Database db = new Database();
           var p = db.Products.GetProductById(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Update(Product p,int id)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.UpdateProduct(p,id);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Products.deleteProduct(id);
            return RedirectToAction("Index");
        }

        public ActionResult ViewDetails(int id)
        {
            Database db = new Database();
            var p = db.Products.GetProductById(id);
            return View(p);
        }

    }
}