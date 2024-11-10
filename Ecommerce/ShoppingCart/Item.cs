using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using POCO;

namespace ShoppingCart
{
    public class Item
    {
       public Product itemProduct { get; set; }
       public int Quantity {  get; set; }

    }
}
