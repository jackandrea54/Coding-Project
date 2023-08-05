using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public bool IsMale { get; set; }

        public Employee(int id, string name, DateTime dob, bool isMale)
        {
            Id = id;
            Name = name;
            Dob = dob;
            IsMale = isMale;
        }

        public override string? ToString()
        {
            return Id + ";" + Name + ";" + Dob + ";" + IsMale; ;
        }
    }
}
