using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class SpecifiedAttributeValue
    {
        public SpecifiedAttributeValue()
        {
            ProductsSpecifiedAttributes = new HashSet<ProductsSpecifiedAttribute>();
        }

        public int SpecifiedAttributeValueId { get; set; }
        public int SpecifiedAttributeId { get; set; }
        public string SpecifiedAttributeValueName { get; set; }

        public virtual SpecifiedAttribute SpecifiedAttribute { get; set; }
        public virtual ICollection<ProductsSpecifiedAttribute> ProductsSpecifiedAttributes { get; set; }
    }
}
