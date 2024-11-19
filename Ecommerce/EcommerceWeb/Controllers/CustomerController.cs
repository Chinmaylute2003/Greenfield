using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM;
using OrderProcessing;

namespace EcommerceWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            iCustomerService svc = new CustomerService();
            List<Customer> customers = svc.GetAll();

            Customer theCustomer = new Customer
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Test",
                EmailAddress = "test@g.com",
                Contact = "1234"
            };

            List<Order> orders = new List<Order>();
            Order order1 = new Order
            {

                Id = 1,
                OrderAmount = 45000,
                OrderDate = DateTime.Now,
                OrderStatus = "delivered"
            };


            Order order2 = new Order
            {

                Id = 2,
                OrderAmount = 45000,
                OrderDate = DateTime.Now,
                OrderStatus = "Not Delivered"
            };

            orders.Add(order1);
            orders.Add(order2);

            CustomerProfile customerProfile = new CustomerProfile { 
                Customer = theCustomer,
                OrderHistory = orders

            };
            ViewData["customerData"] = customerProfile;
            return View();

        }
    }
}