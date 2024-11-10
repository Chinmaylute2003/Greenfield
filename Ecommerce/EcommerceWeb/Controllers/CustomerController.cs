using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM;

namespace EcommerceWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            iCustomerService svc = new CustomerService();
            List<Customer> customers = svc.GetAll();
            
            return View(customers);
        }
    }
}