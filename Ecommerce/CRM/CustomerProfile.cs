using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing;
namespace CRM
{
    public class CustomerProfile
    {
        public  Customer Customer { get; set; }
        public  List<Order> OrderHistory { get; set; }
    }
}
