using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingPortal.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if(email == "chinmay.lute@g.com" && password == "seed")
            {
               return RedirectToAction("Welcome");
            }
            else
            {

            return View();
            }
            return View();

        }
        
        
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }


    }
}