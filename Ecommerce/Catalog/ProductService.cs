using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceEntities;
namespace Catalog
{
    public class ProductService : iProductService
    {
        List<Product> productList;
        public ProductService()
        {
            productList = new List<Product>();
        }
        public bool Delete(Product product)
        {
            return productList.Remove(product);
        }

        public List<Product> GetAll()
        {
    
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
           
            return productList;
        }

        public Product GetProduct(int Id)
        {
            foreach(Product product in productList)
            {
                if(product.Id == Id) { return product; }  
            }
            return null;
        }

  

        public bool Insert(Product product)
        {
            productList.Add(product);
            return true;
        }

        public void Update(Product product)
        {
            Product deletedProduct = GetProduct(product.Id);
            productList.Remove(deletedProduct);
            productList.Add(product);
        }
    }
}
