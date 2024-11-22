using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderProcessing;
using ShoppingCart;

namespace EcommerceWeb.Controllers
{
    public class PaymentsController : Controller
    {
        // GET: Payments
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProceedToPayment()
        {
            OrderService orderSvc = new OrderService();
            Random rand =  new Random();
            Order newOrder = new Order
            {
                Id = rand.Next(50, 101),
                OrderAmount = (int)TempData["totalAmount"],
                OrderStatus = "Purchased",
                OrderDetails = this.HttpContext.Session["myCart"] as Cart

            };
            orderSvc.Insert(newOrder);
            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            cart.ItemList.Clear();
           
           
            return View();
        }
       
    }
}