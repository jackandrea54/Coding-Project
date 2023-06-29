using LAB2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.DataAccess
{
    internal class StudentDAO
    {
        private static List<Student> ConvertToListStudent(DataTable dt)
        {
            List<Student> students = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student(
                row["Id"].ToString(),
                row["Name"].ToString(),
                Convert.ToBoolean(row["Gender"]),
                Convert.ToDateTime(row["Dob"]),
                (new Major(row["Major"].ToString(), row["Title"].ToString())),
                Convert.ToBoolean(row["Active"]),
                Convert.ToDouble(row["Scholarship"])
                ));
            }
            return students;
        }
        private static List<Major> ConvertToListMajor(DataTable dt)
        {
            List<Major> majors = new List<Major>();
            foreach (DataRow row in dt.Rows)
            {
                majors.Add(new Major(
                row["Code"].ToString(),
                row["Title"].ToString()
                ));
            }
            return majors;
        }
        public static List<Student> GetAllStudents()
        {
            String sql = "select s.*, m.Title from Student s join Major m on s.Major = m.Code";
            DataTable dt = DAO.GetDataBySql(sql, null);
            return ConvertToListStudent(dt);
        }
        public static List<Major> GetAllMajor()
        {
            String sql = "Select * from Major";
            DataTable dt = DAO.GetDataBySql(sql, null);
            return ConvertToListMajor(dt);
        }
        public static List<Student> GetStudentByMajor(string majorCode)
        {
            String sql = "select s.*, m.Title from Student s join Major m on s.Major = m.Code and Major = @m";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@m", SqlDbType.VarChar);
            parameter[0].Value = majorCode;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            return ConvertToListStudent(dt);
        }
        public static int InsertStudent(Student s)
        {
            String sql = "insert into Student (Id, [Name], [Gender], [Dob], [Major], [Scholarship], [Active]) values (@id, @name, @gender, @dob, @major, @scholarship, @active)";
            // assign value to String sql above
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[0].Value = s.Id;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[1].Value = s.Name;
            parameters[2] = new SqlParameter("@gender", SqlDbType.Bit);
            parameters[2].Value = s.Gender.Equals("Male") ? 1 : 0;
            parameters[3] = new SqlParameter("@dob", SqlDbType.Date);
            parameters[3].Value = s.Dob;
            parameters[4] = new SqlParameter("@major", SqlDbType.VarChar);
            parameters[4].Value = s.Major.Code;
            parameters[5] = new SqlParameter("@scholarship", SqlDbType.Float);
            parameters[5].Value = s.Scholarship;
            parameters[6] = new SqlParameter("@active", SqlDbType.Bit);
            parameters[6].Value = s.Active ? 1 : 0;
            return DAO.ExecuteSql(sql, parameters);
        }
        public static int UpdateStudent(Student s)
        {
            string sql = "update Student set Name = @name, Gender = @gender, Dob = @dob, Major = @major, Active = @active, Scholarship = @scholarship where id = @id";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = s.Name;
            parameters[1] = new SqlParameter("@gender", SqlDbType.Bit);
            parameters[1].Value = s.Gender.Equals("Male") ? 1 : 0;
            parameters[2] = new SqlParameter("@dob", SqlDbType.Date);
            parameters[2].Value = s.Dob;
            parameters[3] = new SqlParameter("@major", SqlDbType.VarChar);
            parameters[3].Value = s.Major.Code;
            parameters[4] = new SqlParameter("@active", SqlDbType.Bit);
            parameters[4].Value = s.Active ? 1 : 0;
            parameters[5] = new SqlParameter("@scholarship", SqlDbType.Float);
            parameters[5].Value = s.Scholarship;
            parameters[6] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[6].Value = s.Id;
            return DAO.ExecuteSql(sql, parameters);
        }
        public static int CheckStudentExit(String studentId)
        {
            string sql = "select count(*) from student where Id = @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", SqlDbType.VarChar);
            parameter[0].Value = studentId;
          
            return Convert.ToInt32(DAO.GetDataBySql(sql, parameter).Rows[0][0].ToString());
        }
        public static int DeleteStudent(String id)
        {
            String sql = "delete from student where Id = @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", SqlDbType.VarChar);
            parameter[0].Value = id;
            return DAO.ExecuteSql(sql, parameter);
        }
    }
}
