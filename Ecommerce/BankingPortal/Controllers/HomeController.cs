using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Models;

namespace BankingPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string companyName = "Simplify Healthcare";
            ViewBag.company = companyName;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            Contact contact = new Contact { ContactNumber = "122143", Email = "sh@simplifyhealthcare.com", Website = "simplifyhealthcare.com" };
            ViewData["contact"] = contact;
            return View();
        }
    }
}