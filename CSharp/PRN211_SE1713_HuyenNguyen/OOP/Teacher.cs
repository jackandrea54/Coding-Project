using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Teacher
    {
        //Thuoc tinh
        public string Code { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Phuong thuc
        public Teacher()
        {
        }

        public Teacher(string code, string name)
        {
            Code = code;
            Name = name; //su dung ham set cho thuoc tinh
            _name = name; //gan truc tiep cho thuoc tinh
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + GetSalary();
        }

        public abstract double GetSalary();
    }
}
