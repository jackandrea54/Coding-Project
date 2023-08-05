using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TeacherComparer : Comparer<Teacher>
    {
        public override int Compare(Teacher? x, Teacher? y)
        {
            if (x.GetSalary() - y.GetSalary() < 0)
            {
                return -1;
            }
            else if (x.GetSalary() - y.GetSalary() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
