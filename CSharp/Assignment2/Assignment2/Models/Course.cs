using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }



        public Course(int courseId, string courseCode)
        {
            CourseId = courseId;
            CourseCode = courseCode;
        }
    }
}
