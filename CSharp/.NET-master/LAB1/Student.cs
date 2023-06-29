using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Major { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearAdmitted { get; set; }
        public float SchollarShip { get; set; }
        public override string ToString()
        {
            return $"{Id}|{Name}|{Major}|{Convert.ToDateTime(DateOfBirth):dd MMM yyyy}|{YearAdmitted}|{SchollarShip}";
        }
        public Student ReadFromLine(String line)
        {
            Student student = new Student();
            try
            {
                String[] temp = line.Split("|");
                if (temp.Length == 6)
                {
                    student.Id = int.Parse(temp[0].Trim());
                    student.Name = temp[1].Trim();
                    student.Major = temp[2].Trim();
                    student.DateOfBirth = DateTime.ParseExact(temp[3], "dd MMM yyyy", null);
                    student.YearAdmitted = int.Parse(temp[4].Trim());
                    student.SchollarShip = float.Parse(temp[5].Trim());
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
            return student;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
