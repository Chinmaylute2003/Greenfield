using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using EcommerceEntities;

namespace ShoppingCart
{
    public class Item
    {
       public int ProductId { get; set; }
       public int Quantity {  get; set; }

    }
}
