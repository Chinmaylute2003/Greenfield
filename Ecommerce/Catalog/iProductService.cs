﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceEntities;
namespace Catalog
{
    public interface iProductService
    {
         List<Product> GetAll();
         Product GetProduct(int Id);
         bool Insert(Product product);
         bool Delete(Product product);
         void Update(Product product);
       
    }
}
