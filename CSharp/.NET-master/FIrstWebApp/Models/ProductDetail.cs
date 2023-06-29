using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }

        public virtual Product ProductDetailNavigation { get; set; }
    }
}
