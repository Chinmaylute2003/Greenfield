using Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryDataRepositoryLib;
using Services;
using POCO;

namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          iProductService svc = new ProductService();
          ProductService pSvc = (ProductService)svc;
            pSvc.Seeding();
            List<Product> products = svc.GetAll();
            foreach(Product p in products)
            {
                Console.WriteLine(p.Id + " " + p.Title);
            }
            Console.ReadLine();
            
        }
    }
}
