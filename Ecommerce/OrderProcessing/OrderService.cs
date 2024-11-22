using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONDataRepositoryLib;
namespace OrderProcessing
{
    public class OrderService
    {
        List<Order> orderList;
        private string filePath = @"E:/orders.json";
        private JSONRepository<Order> svc = null; 
        public OrderService() {
            orderList = new List<Order>();
            svc = new JSONRepository<Order>();
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
            List<Order> orders = svc.Deserialize(filePath);
            orders.Add(order);
            svc.Serialize(filePath, orders);
      
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
