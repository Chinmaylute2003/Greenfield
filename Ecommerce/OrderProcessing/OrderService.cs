using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    internal class OrderService
    {
        List<Order> orderList;
        public OrderService() {
            orderList = new List<Order>();
        }
        public List<Order> GetAll()
        {
            return orderList;
        }
        public Order GetOrder(int Id)
        {
            foreach(Order o in orderList)
            {
                if(o.Id == Id)
                {
                    return o;
                }
            }
            return null;
        }
        public bool Insert(Order order)
        {
            orderList.Add(order);
            return true;
        }
        public bool Delete(Order order)
        {
             return orderList.Remove(order);
        }
        public void Update(Order order)
        {
            Order deletedOrder = GetOrder(order.Id);
            orderList.Remove(deletedOrder);
            orderList.Add(order);
        }

    }
}
