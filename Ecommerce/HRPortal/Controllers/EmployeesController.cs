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
        private static int empCount = 1;
        public EmployeesController()
        {
            empSvc = new EmployeeService();

        }
        public ActionResult Index()
        {
            ViewData["employeeList"] = empSvc.ReadAll();
            return View();
        }


        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Employee e)
        {
            e.Id = empCount++;
            empSvc.Create(e);
            TempData["username"] = e.Name;
            return RedirectToAction("Success");
        }

        public ActionResult Edit(int id)
        {
            Employee emp = empSvc.Read(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            empSvc.Update(e);

            return RedirectToAction("Index", "Employees");
        }


        public ActionResult Details(int id)
        {
            Employee e = empSvc.Read(id);
            return View(e);
        }
        public ActionResult Delete(int id)
        {
            List<Employee> empList = empSvc.ReadAll();
            Employee emp = empList.Find(x => x.Id == id);
            empSvc.Delete(emp);
            return RedirectToAction("Index");
        }


        public ActionResult Success()
        {
            ViewBag.username = TempData["username"] as string;
            return View();
        }
    }
}