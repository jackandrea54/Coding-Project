using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class FullTime : Teacher
    {
        public double Heso { get; set; }

        public FullTime()
        {
        }

        public FullTime(string code, string name, double heso) : base(code, name)
        {
            Heso = heso;
        }

        public override double GetSalary()
        {
            return Heso * 1800000;
        }
    }
}
