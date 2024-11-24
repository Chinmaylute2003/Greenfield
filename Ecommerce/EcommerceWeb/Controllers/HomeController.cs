using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.XPath;
using Catalog;
using EcommerceServices;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(string email, string password)
        {
            string res = "Failed";
            AuthService authService = new AuthService();
            if(authService.Login(email, password))
            {

                 res = "OK";
                
            }
            
            return Json(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Storage()
        {
            return View();
        }

        public ActionResult Paint()
        {
            return View();
        }
    }
}