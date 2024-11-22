using EcommerceEntities;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceServices;
using OrderProcessing;

namespace EcommerceWeb.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ProceedToBuy()
        {
            return View();
        }

           
      
    }
}