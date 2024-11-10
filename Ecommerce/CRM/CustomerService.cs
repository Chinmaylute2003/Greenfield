using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM
{
    public class CustomerService : iCustomerService
    {
        List<Customer> customerList;

        public CustomerService()
        {
            customerList = new List<Customer>();
        }

        public bool Delete(Customer customer)
        {
            return customerList.Remove(customer);
        }

        public List<Customer> GetAll()
        {

         
            //Property Intializer Syntax
            Customer cust1 = new Customer
            {
                Id = 1,
                FirstName = "Chinmay",
                LastName = "Lute",
                EmailAddress = "chinmay.lute@gmail.com",
                Contact = "8208724263"
            };

            Customer cust2 = new Customer
            {
                Id = 1,
                FirstName = "Krunal",
                LastName = "Lute",
                EmailAddress = "krunal.lute@gmail.com",
                Contact = "8625033211"

            };

            Customer cust3 = new Customer
            {
                Id = 1,
                FirstName = "Rajan",
                LastName = "Patil",
                EmailAddress = "rajan.patil@gmail.com",
                Contact = "8625033211"
            };
            customerList.Add(cust1);
            customerList.Add(cust2);
            customerList.Add(cust3);

            return customerList;
        }

        public Customer GetCustomer(int Id)
        {
 
            foreach (Customer customer in customerList){
              if(customer.Id == Id)
                {
                    return customer;
                }
            }
            return null;
        }

        public bool Insert(Customer customer)
        {
            customerList.Add(customer);
            return true;
        }

        public void Update(Customer customer)
        {
            Customer deletedCustomer = GetCustomer(customer.Id);
            customerList.Remove(deletedCustomer);
            customerList.Add(customer);

        }
    }
}
