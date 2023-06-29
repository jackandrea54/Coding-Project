using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
        public int RoleId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Validator { get; set; }
        public string Cookie { get; set; }

        public virtual Role Role { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
