using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartService:iCartService
    {
        public CartService() {
            
        }

        public bool AddToCart(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Clear()
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item GetItem(int Id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromCart(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
