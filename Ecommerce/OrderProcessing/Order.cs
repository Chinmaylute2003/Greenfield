﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart;

namespace OrderProcessing
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus {  get; set; }
        public int OrderAmount {  get; set; }

        public Cart OrderDetails { get; set; }

    }
}
