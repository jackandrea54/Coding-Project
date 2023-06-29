using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1422
{
    class Customer : Account
    {
        public Customer()
        {
        }

        public Customer(string username, string password, string name, DateTime dob) : base (username, password)
        {
            DOB = dob;
            Name = name;
        }

        public DateTime DOB { get; set; }
        public string Name { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("Name: ");
            Name = Console.ReadLine().Trim();
            while (true)
            {
                try
                {
                    Console.Write("Date of birth: ");
                    DOB = DateTime.Parse(Console.ReadLine().Trim());
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
            //return $"Customer: {base.ToString()} - {Name} - {DOB}";
            return $"Customer|{Username}|{Password}|{Name}|{Convert.ToDateTime(DOB):dd MMM yyyy}";
        }
    }
}
