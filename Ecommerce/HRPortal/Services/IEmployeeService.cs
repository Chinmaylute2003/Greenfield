using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Services
{
    public interface IEmployeeService
    {
        bool Create(Employee emp);
        Employee Read(int Id);

        bool Update(Employee emp);
        bool Delete(Employee emp);

        List<Employee> ReadAll();
    }
}
