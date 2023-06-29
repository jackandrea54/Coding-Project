using System;
using System.Collections.Generic;

#nullable disable

namespace DemoFirstStudent.Models
{
    public partial class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; }
        public double Scholarship { get; set; }
        public bool Active { get; set; }

        public virtual Major MajorNavigation { get; set; }
    }
}
