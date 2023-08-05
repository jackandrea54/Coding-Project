using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public int Department { get; set; }
        public string DepartmentName { get; set; }

        public Employees(int id, string name, string dob, string sex, string position, int department, string departmentname)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Sex = sex;
            Position = position;
            Department = department;
            DepartmentName = departmentname;
        }

        public Employees(string position)
        {
            Position = position;
        }
    }
}
