using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PartTime : Teacher
    {
        public int Slot { get; set; }

        public PartTime()
        {
        }

        public PartTime(string code, string name, int slot) : base(code, name)
        {
            Slot = slot;
        }

        public override double GetSalary()
        {
            return Slot * 100000;
        }
    }
}
