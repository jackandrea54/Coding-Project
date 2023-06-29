using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Models
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public String Gender { get; set; }
        public DateTime Dob { get; set; }
        public Major Major { get; set; }
        public bool Active { get; set; }
        public double Scholarship { get; set; }


        public Student(string id, string name, bool gender, DateTime dob, Major major, bool active, double scholarship)
        {
            Id = id;
            Name = name;
            Gender = gender ? "Male" : "Female";
            Dob = dob;
            Major = major;
            Active = active;
            Scholarship = scholarship;
        }

        public Student()
        {
            Scholarship = 0;
            Dob = DateTime.Today;
        }

    }
}
