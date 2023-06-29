using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Sale
    {
        public Sale()
        {
            Orders = new HashSet<Order>();
        }

        public int SaleId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailContact { get; set; }

        public virtual Account SaleNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
