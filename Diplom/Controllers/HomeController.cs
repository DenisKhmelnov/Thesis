using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diplom.Models;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        FloverStoreDB db = new FloverStoreDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductCatalog()
        {
            // получаем из бд все объекты Book
            IEnumerable<Product> products = db.Products;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Products = products;
            // возвращаем представление
            return View();
        }

        public ActionResult ProductCard(int?id)
        {
            var product = db.Products.Find(id);

            return View(product);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}