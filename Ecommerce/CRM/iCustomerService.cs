using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public interface iCustomerService
    {
        List<Customer> GetAll();
        Customer GetCustomer(int Id);
        bool Insert(Customer customer);
        bool Delete(Customer customer);
        void Update(Customer customer);

    }
}
