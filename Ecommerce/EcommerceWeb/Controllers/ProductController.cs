
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceEntities;
using EcommerceServices;
using Specification;

namespace EcommerceWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            iProductService svc = new ProductService();
            List<Product> products = svc.GetAll();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            iProductService svc = new ProductService();
            Product product = svc.GetProduct(id);
            ViewBag.productInfo = product;
            return View();
        }

        public ActionResult Insert()
        {

            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}