﻿using System;
using System.Collections.Generic;

namespace Store.Data.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
