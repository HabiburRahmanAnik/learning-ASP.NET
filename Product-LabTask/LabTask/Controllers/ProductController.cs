using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using LabTask.Models;
using LabTask.Models.Entity;

namespace LabTask.Controllers
{
    public class ProductController : Controller
    {
        private object products;

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

        [HttpGet]
        public ActionResult Card(int id)
        {
            List<Product> products = null;
            Database db = new Database();
            var product = db.Products.GetProductById(id);

            if(Session["card"] == null)
            {
                products = new List<Product>();
                products.Add(product);
                string json = new JavaScriptSerializer().Serialize(products);
                Session["card"] = json;
                return View(products);
            }
            else
            {
                var item = Session["card"].ToString();
                products = new JavaScriptSerializer().Deserialize<List<Product>>(item);
                products.Add(product);
                string json = new JavaScriptSerializer().Serialize(products);
                Session["card"] = json;
                return View(products);
            }
        }

        [HttpPost]
        public ActionResult Cart()
        {
            List<Product> products = new List<Product>();
            var item = Session["card"].ToString();
            products = new JavaScriptSerializer().Deserialize<List<Product>>((string)item);

            Database db = new Database();
            db.Orders.AddOrderToCard(products);

            Session["card"] = null;

            return RedirectToAction("Index");
        }

    }
}