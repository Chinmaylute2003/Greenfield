using HRPortal.Models;
using HRPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace HRPortal.Services
{
    public class EmployeeService : IEmployeeService
    {
        private string filePath = @"E:/emp.json";
        private IDataRepository<Employee> svc  = null;
       
        public EmployeeService()
        {
            svc = new JSONRepository<Employee>();
            //Seeding();
        }

        public bool Seeding()
        {
            Employee emp = new Employee { Name = "Chinmay", BasicSalary = 50000, DailyAllowance = 22, isConfirmed = true, JoinDate = new DateTime(2024, 2, 8), WorkingDays = 22 };
            List<Employee> list = new List<Employee>();
            list.Add(emp);
            svc.Serialize(filePath, list);
            return true;
        }
        public bool Create(Employee emp)
        {
            List<Employee> empList = svc.Deserialize(filePath);
            empList.Add(emp);
            svc.Serialize(filePath, empList);
            return true;

            
        }

        public bool Delete(Employee emp)
        {
            List<Employee> empList = svc.Deserialize(filePath);
            if(!empList.Remove(emp))
                return false;
            svc.Serialize(filePath, empList);
            return true;
        }

        public Employee Read(int Id)
        {
            List<Employee> empList = svc.Deserialize(filePath);
            Employee empFound = null;
            foreach(Employee emp in empList)
            {
                if(emp.Id == Id)
                    empFound = emp;
            }
            return empFound;

        }

        public bool Update(Employee emp)
        {
            List<Employee> empList = svc.Deserialize(filePath);
            Employee employeeToBeDeleted = empList.Find(X => X.Id == emp.Id);
            if (!empList.Remove(employeeToBeDeleted))
                return false;
            empList.Add(emp);
            svc.Serialize(filePath, empList);  
            return true;
        }

        public List<Employee> ReadAll()
        {
            return svc.Deserialize(filePath);
        }   

        
    }
}