using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1422
{
    public class Employee : Account
    {
        public string Role { get; set; }
        public double Salary { get; set; }

        public Employee(string username, string password, double salary, string role) : base(username, password)
        {
            Role = role;
            Salary = salary;
        }

        public Employee()
        {
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Role: ");
            Role = Console.ReadLine().Trim();
            while (true)
            {
                try
                {
                    Console.Write("Salary: ");
                    Salary = Double.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. Enter again.");
                }
            }
        }

        public override string ToString()
        {
            //return $"Employee: {base.ToString()} - {Salary} - {Role}";
            return $"Employee|{Username}|{Password}|{Salary}|{Role}";
        }
    }
}
