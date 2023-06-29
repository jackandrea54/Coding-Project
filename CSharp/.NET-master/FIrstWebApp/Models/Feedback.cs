using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int CustomerId { get; set; }
        public int OrderDetailId { get; set; }
        public string Comment { get; set; }
        public short Rating { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
