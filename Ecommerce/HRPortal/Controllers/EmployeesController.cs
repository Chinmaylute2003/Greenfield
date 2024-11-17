using HRPortal.Models;
using HRPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        private EmployeeService empSvc = null;
        public EmployeesController()
        {
            empSvc = new EmployeeService();
            
        }
        public ActionResult Index()
        {
            ViewData["employeeList"] = empSvc.ReadAll();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            string firstName = collection["firstName"] as string;
            string lastName = collection["lastName"] as string;
            string email = collection["email"] as string;
            string contact = collection["contactNumber"] as string;

            return View();
        }

        public  ActionResult Insert() 
        {
            return View(); 
        }
        
        [HttpPost]
        public ActionResult Insert(Employee e)
        {
            empSvc.Create(e);
            return View();
        }

        public ActionResult Edit(int id)
        {  
            Employee emp =empSvc.Read(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            empSvc.Update(e);

            return RedirectToAction("Index", "Employees");
        }
        
        public ActionResult Delete(int id)
        {
            Employee emp = empSvc.Read(id);
            empSvc.Delete(emp);
            return RedirectToAction("Index", "Employees")
        }
    }

}