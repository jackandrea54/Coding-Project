using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class SpecifiedAttribute
    {
        public SpecifiedAttribute()
        {
            SpecifiedAttributeValues = new HashSet<SpecifiedAttributeValue>();
        }

        public int SpecifiedAttributeId { get; set; }
        public string SpecifiedAttributeName { get; set; }
        public string SpecifiedAttributeQueryName { get; set; }

        public virtual ICollection<SpecifiedAttributeValue> SpecifiedAttributeValues { get; set; }
    }
}
