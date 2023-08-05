using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Winform_ADO
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Salary { get; set; }

        public DateTime DOB { get; set; }
        public Employee()
        {

        }

        public Employee(int id, string name, int yob, int salaray)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Salary = salaray;
        }

        public Employee(int id, string name, DateTime dob, int yob, int salaray)
        {
            Id = id;
            Name = name;
            DOB = dob;
            Yob = yob;
            Salary = salaray;
        }

        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Yob + "\t" + Salary;
        }
    }
}
