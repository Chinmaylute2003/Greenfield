﻿using BankingPortal.Services;
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
            this.HttpContext.Session["loggedin"] = email;
           if(email == "chinmay.lute@g.com" && password == "seed")
            {
                
                return RedirectToAction("welcome");
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
            return View();
        }

    }
}