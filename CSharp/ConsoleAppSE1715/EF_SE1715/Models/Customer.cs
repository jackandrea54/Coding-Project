using System;
using System.Collections.Generic;

namespace EF_SE1715.Models;

public partial class Customer
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int CustId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
