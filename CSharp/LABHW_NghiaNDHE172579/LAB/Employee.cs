using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Employee
    {
        public int id { get; set; }
        public String name { get; set; }
        public double salary { get; set; }
        public String position { get; set; }
        public override string ToString()
        {
            return $"{id}|{name}|{salary}|{position}|{salaryCalculation(salary, position)}";
        }

        public delegate double SalaryCalculation(double salary, string position);

        public SalaryCalculation salaryCalculation;

        public Employee ReadFromLine(String line)
        {
            Employee employee = new Employee();
            try
            {
                String[] temp = line.Split("|");
                if (temp.Length == 4)
                {
                    employee.id = int.Parse(temp[0].Trim());
                    employee.name = temp[1].Trim();
                    employee.salary = double.Parse(temp[2].Trim());
                    employee.position = temp[3].Trim();
                    Employee.SalaryCalculation calculation;
                    if (employee.position.ToLower() == "manager")
                    {
                        calculation = (salary, position) => salary * 16;
                    }
                    else if (employee.position.ToLower() == "developer")
                    {
                        calculation = (salary, position) => salary * 14;
                    }
                    else
                    {
                        calculation = (salary, position) => salary * 12;
                    }
                    employee.salaryCalculation = calculation;
                    employee.Display(calculation);
                }
                else
                {
                    throw new FormatException("Wrong format file");
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Wrong format file");
            }
            return employee;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   id == employee.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public void Display(SalaryCalculation calculation)
        {
            Console.WriteLine($"id of employee: {id}. name of Employee: {name}. Salary: {salary}. Position: {position}");
            double yearlySalary = calculation(salary, position);
            Console.WriteLine($"Yearly Salary: {yearlySalary}");
        }
    }
}
