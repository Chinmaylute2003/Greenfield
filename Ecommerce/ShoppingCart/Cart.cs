using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
       public List<Item> ItemList { get; set; }
       public Cart() { ItemList = new List<Item>(); }
    }
}
