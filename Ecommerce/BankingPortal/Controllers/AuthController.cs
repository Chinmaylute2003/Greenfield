using BankingPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Models;

namespace BankingPortal.Controllers
{
    public class AuthController : Controller
    {
        private AuthService svc;
        public AuthController()
        {
            svc = new AuthService();
        }
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            if(svc.Login(email, password))
            {
                this.HttpContext.Session["loggedin"] = email;
                return RedirectToAction("Welcome");
            }
            
            return View();

        }
        
        
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Register(string firstName, string lastName, string password, string email, string contactNumber)
        {
            User newUser = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password, Contact = contactNumber};
            if (svc.Register(newUser))
            {
                TempData["responseMessage"] = "User registered successfully!";
                return RedirectToAction("Success");
            }
            return View();
        }

        public ActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResetPassword(string email, string oldPassword, string newPassword)
        {
            if(svc.ResetPassword(email, oldPassword, newPassword))
            {
                TempData["responseMessage"] = "Password changed successfully!";
                return RedirectToAction("Success");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.userEmail = this.HttpContext.Session["loggedin"] as string;
            return View();
        }

        public ActionResult Success()
        {
            ViewBag.responseMessage = TempData["responseMessage"] as string;
            return View();
        }

    }
}