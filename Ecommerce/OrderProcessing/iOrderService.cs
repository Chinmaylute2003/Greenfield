using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface iOrderService
    {
        List<Order> GetAll();
        Order GetOrder(int Id);
        bool Insert(Order order);
        bool Delete(Order order);
        void Update(Order order);
    }
}
