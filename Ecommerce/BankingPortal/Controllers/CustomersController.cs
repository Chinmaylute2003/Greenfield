using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Models;

namespace BankingPortal.Controllers
{
    public class CustomersController : Controller
    {
            List<Customer> customers = new List<Customer>();
        public CustomersController()
        {
            customers.Add(new Customer { Id = 1, Name = "Microsoft", Email = "bill@ms.com", Location = "Hyderabad" });
            customers.Add(new Customer { Id = 2, Name = "IBM", Email = "johny@ms.com", Location = "Mumbai" });
            customers.Add(new Customer { Id = 2, Name = "Simplify", Email = "simple@ms.com", Location = "Pune" });

        }
        // GET: Customers
        public ActionResult Index()
        {
           
            ViewData["custList"] = customers;

            return View();
        }

        public ActionResult Detail(int id)
        {
            //model is passed from action method to view
            Customer customer = customers.Find(c => c.Id == id);
            return View(customer);
        }
    }
}