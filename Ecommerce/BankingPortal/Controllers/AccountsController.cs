using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingPortal.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {

            string msg = "Hi had come from Index";
            TempData["message"] = msg;
            return View();
        }

        public ActionResult Process()
        {
            string msg = TempData["message"] as string;
            ViewBag.message = msg;
            return View();
        }
    }
}