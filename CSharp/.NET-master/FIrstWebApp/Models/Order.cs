using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? SaleId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string NoteOrder { get; set; }
        public decimal? TotalTransaction { get; set; }
        public int? PayMethod { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
