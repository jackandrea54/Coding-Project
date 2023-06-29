using LAB2.DataAccess;
using LAB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Logics
{
    internal class StudentManager
    {

        public static List<Student> GetAllStudents()
        {
            return StudentDAO.GetAllStudents();
        }
        public static List<Major> getAllMajors()
        {
            return StudentDAO.GetAllMajor();
        }
        public static List<Student> GetStudentByMajor(string majorCode)
        {
            return StudentDAO.GetStudentByMajor(majorCode);
        }
        public static int InsertStudent(Student student)
        {
            return StudentDAO.InsertStudent(student);
        }
        public static int UpdateStudent(Student student)
        {
            return StudentDAO.UpdateStudent(student);
        }
        public static int DeleteStudent(String StudentId)
        {
            return StudentDAO.DeleteStudent(StudentId);
        }
        public static int CheckStudentIsExit(String studentId)
        {
            return StudentDAO.CheckStudentExit(studentId);
        }


    }
}
