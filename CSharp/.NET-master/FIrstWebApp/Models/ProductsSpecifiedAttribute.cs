using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class ProductsSpecifiedAttribute
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SpecifiedAttributeValueId { get; set; }

        public virtual Product Product { get; set; }
        public virtual SpecifiedAttributeValue SpecifiedAttributeValue { get; set; }
    }
}
