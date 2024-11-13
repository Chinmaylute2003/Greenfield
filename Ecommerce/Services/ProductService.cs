using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceEntities;
using Specification;
using JSONDataRepositoryLib;
using System.Configuration;
namespace EcommerceServices
{
    public class ProductService : iProductService
    {
        List<Product> productList;
        public string filePath = @"E:/product.dat";

        public bool Seeding()
        {
            bool status = false;
            Product product1 = new Product
            {
                Id = 1,
                Title = "Flower1",
                Description = "This is flower1",
                UnitPrice = 12,
                Quantity = 500,
                Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ2Fdk2zmMO7NkEdqxw-iUFPQBksQ8TWi5eGyC35UrllsjD5SBL"

            };
            Product product2 = new Product
            {
                Id = 2,
                Title = "Flower2",
                Description = "This is flower2",
                UnitPrice = 10,
                Quantity = 500,
                Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ2Fdk2zmMO7NkEdqxw-iUFPQBksQ8TWi5eGyC35UrllsjD5SBL"

            };

            productList.Add(product1);
            productList.Add(product2);
            IDataRepository<Product> svc = new JSONRepository<Product>();
            status = svc.Serialize(filePath, productList);
            return status;
        }
        public ProductService()
        {
            productList = new List<Product>();
            Seeding();
        }
        public bool Delete(Product product)
        {
            bool status = false;
            List<Product> products = new List<Product>();
            products = GetAll();
            products.Remove(product);
            IDataRepository<Product> svc = new JSONRepository<Product>();
            status  = svc.Serialize(filePath, products);
            return status;

        }

        public List<Product> GetAll()
        {
            
            List<Product> allProducts = new List<Product>();
            IDataRepository<Product> svc = new JSONRepository<Product>();
            allProducts = svc.Deserialize(filePath);  
            return allProducts;
        }

        public Product GetProduct(int Id)
        {
            Product productFound = null;
            List<Product> products = new List<Product>();
            products = GetAll();
            foreach(Product product in products)
            {
                if(product.Id == Id)
                {
                    productFound = product;
                    break;
                }
            }
            return productFound;
        }

  

        public bool Insert(Product product)
        {
            bool status = false;
            List<Product> allProducts = new List<Product>();
            allProducts = GetAll();
            allProducts.Add(product);
            IDataRepository<Product> svc = new JSONRepository<Product>();
            svc.Serialize(filePath, allProducts);
            status = true;
            return status;
        }

        public void Update(Product productToBeUpdated)
        {
            List<Product> allProducts = new List<Product>();
            allProducts = GetAll();
            Product productToBeDeleted = GetProduct(productToBeUpdated.Id);
            allProducts.Remove(productToBeDeleted);
            allProducts.Add(productToBeUpdated);
            IDataRepository<Product> svc = new JSONRepository<Product>();
            svc.Serialize(filePath, allProducts);
           
        }
    }
}
