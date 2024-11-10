﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specification;
using BinaryDataRepositoryLib;
using System.Configuration;
namespace Services
{
    public class ProductService : iProductService
    {
        List<Product> productList;

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
                Id = 1,
                Title = "Flower2",
                Description = "This is flower2",
                UnitPrice = 10,
                Quantity = 500,
                Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ2Fdk2zmMO7NkEdqxw-iUFPQBksQ8TWi5eGyC35UrllsjD5SBL"

            };

            productList.Add(product1);
            productList.Add(product2);
            IDataRepository svc = new BinaryRepository();
            status = svc.Serialize("C:\\Users\\chinmay.lute\\source\\repos\\SimplifyHealthcare\\SerializationWebApp\\product.dat", productList);
            return status;
        }
        public ProductService()
        {
            productList = new List<Product>();
        }
        public bool Delete(Product product)
        {
            bool status = false;
            List<Product> products = new List<Product>();
            products = GetAll();
            products.Remove(product);
            IDataRepository svc = new BinaryRepository();
            status  = svc.Serialize("C:\\Users\\chinmay.lute\\source\\repos\\SimplifyHealthcare\\SerializationWebApp\\product.dat", products);
            return status;

        }

        public List<Product> GetAll()
        {
            
            List<Product> allProducts = new List<Product>();
            IDataRepository svc = new BinaryRepository();
            allProducts = svc.Deserialize("C:\\Users\\chinmay.lute\\source\\repos\\SimplifyHealthcare\\SerializationWebApp\\product.dat");  
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
            IDataRepository svc = new BinaryRepository();
            svc.Serialize("C:\\Users\\chinmay.lute\\source\\repos\\SimplifyHealthcare\\SerializationWebApp\\product.dat", allProducts);
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
            IDataRepository svc = new BinaryRepository();
            svc.Serialize("C:\\Users\\chinmay.lute\\source\\repos\\SimplifyHealthcare\\SerializationWebApp\\product.dat", allProducts);
           
        }
    }
}
