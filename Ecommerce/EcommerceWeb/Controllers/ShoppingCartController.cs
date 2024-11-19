using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            Cart cart =  this.HttpContext.Session["myCart"] as Cart;
           
            ViewData["cart"] = cart;
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            ViewBag.itemId = id;
            ViewBag.quantity = 0;

            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            cart.ItemList.Add(new Item { ProductId = id, Quantity = quantity });
            return View();
        }
    }
}