using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }

        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
