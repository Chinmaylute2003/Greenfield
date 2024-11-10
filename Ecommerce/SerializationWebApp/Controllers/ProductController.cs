using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO;
using Specification;
using Services;


namespace SerializationWebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> products = svc.GetAll();

            return View(products);
        }
        public ActionResult AddDetails()
        {

            return View();
        }
    }
}