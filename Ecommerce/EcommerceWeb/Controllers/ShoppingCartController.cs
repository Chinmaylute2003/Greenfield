using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceServices;
namespace EcommerceWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            Cart cart =  this.HttpContext.Session["myCart"] as Cart;
            ProductService svc = new ProductService();
            int total = 0;
            foreach(Item item in cart.ItemList)
            {
                total += svc.GetProduct(item.ProductId).UnitPrice * item.Quantity;
            }
            ViewBag.total = total;
            ViewData["cart"] = cart;
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            int quant = 0;
            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            Item item = cart.ItemList.Find((x)=>x.ProductId == id);
            if (item != null)
            {
                quant = item.Quantity;
            }

            ViewBag.itemId = id;
            ViewBag.quantity = quant;
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            Item itemExist = cart.ItemList.Find((x) => x.ProductId == id);
            if (itemExist != null)
            {
                Item newItem = new Item
                {
                    ProductId = id,
                    Quantity = itemExist.Quantity + quantity
                };
                cart.ItemList.RemoveAll((x) => x.ProductId == id);
                cart.ItemList.Add(newItem);
            }
            else
            {
                cart.ItemList.Add(new Item { ProductId = id, Quantity = quantity });
            }

            return RedirectToAction("index", "Product");
        }

        public ActionResult Delete(int id)
        {
            Cart myCart = this.HttpContext.Session["myCart"] as Cart;
            myCart.ItemList.RemoveAll((x) => x.ProductId == id);

            return RedirectToAction("index");
        }

        public ActionResult Edit(int id) {
            ProductService svc = new ProductService();
            ViewBag.id = id;
            ViewBag.productTitle = svc.GetProduct(id).Title;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int productId, int quantity)
        {

            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            Item itemFound = cart.ItemList.Find((x) => x.ProductId == productId);
            itemFound.Quantity = quantity;
           
            return RedirectToAction("index");
        }
       
    }   
}