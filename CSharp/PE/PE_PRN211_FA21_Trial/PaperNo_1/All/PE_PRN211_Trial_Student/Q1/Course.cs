using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Course
    {
        public int CoutseID { get; set; }

        internal void AddStudent(Student s, double v)
        {
            int oldNumber, newNumber;
            oldNumber = list.Count;
            list.Add(s, v);
            newNumber = list.Count;
            if(OnNumberOfStudentChange != null)
                OnNumberOfStudentChange(oldNumber, newNumber);
        }

        public string CourseTitle { get; set; }
        public event Action<int, int> OnNumberOfStudentChange;

        internal void RemoveStudent(int stdId)
        {
            int oldNumber, newNumber;
            oldNumber = list.Count;
            foreach (Student s in list.Keys)
                if (s.StudentID == stdId)
                    list.Remove(s);
            newNumber = list.Count;
            if (OnNumberOfStudentChange != null)
                OnNumberOfStudentChange(oldNumber, newNumber);
            
        }

        private Dictionary<Student, double> list;

        public Course()
        {
            list = new Dictionary<Student, double>();
        }

        public Course(int coutseID, string courseTitle)
        {
            list = new Dictionary<Student, double>();
            CoutseID = coutseID;
            CourseTitle = courseTitle;
        }

        public Course(int coutseID, string courseTitle, Dictionary<Student, double> list)
        {
            CoutseID = coutseID;
            CourseTitle = courseTitle;
            this.list = list;
        }

        public override string ToString()
        {
            string msg = "Course: " + CoutseID + " - " + CourseTitle;
            foreach (Student s in list.Keys)
                msg += $"\nStudent: {s.StudentID} - {s.StudentName} - Mark: {list[s]}";
            return msg;            
        }
    }
}
