using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOApp.DAL;
using ADOApp.Models;
using Assignment2.Models;

namespace Assignment2.DAL
{
    internal class CourseDAO
    {
        public static List<Course> GetAllCourseCode()
        {
            string sql = "Select CourseId, CourseCode from COURSES";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Course> courses = new List<Course>();
            foreach (DataRow dr in dt.Rows)
                courses.Add(new Course(
                    Convert.ToInt32(dr["CourseId"]),
                    dr["CourseCode"].ToString()));
            return courses;
        }



        public static DataTable GetAllCourses()
        {
            string sql = "select * from Courses";
            DataTable dt = DAO.GetDataBySql(sql);
            return dt;
        }

        public static DataTable GetCourseForDataGrid()
        {
            string sql = "select table1.IsAbsent,table1.StudentId,table1.Roll#, table1.FirstName, table1.MidName, table1.LastName,table2.CourseCode,table2.TeachingScheduleId," +
                " table2.TeachingDate from \r\n(Select stu.*,rcb.IsAbsent,rcb.TeachingScheduleId from Students stu inner join ROLL_CALL_BOOKS rcb on " +
                "stu.StudentId = rcb.StudentId) table1\r\ninner join \r\n(Select c.CourseId,c.CourseCode,cs.TeachingScheduleId,cs.TeachingDate " +
                "from COURSES c inner join COURSE_SCHEDULES cs on c.CourseId = cs.CourseId) table2\r\non table1.TeachingScheduleId = table2.TeachingScheduleId";
            DataTable dt = DAO.GetDataBySql(sql);
            return dt;
        }

        public static DataTable GetCourseByCourseDate(String codeInput, String dateInput)
        {
            string sql = @"SELECT table1.IsAbsent, table1.StudentId, table1.Roll#, table1.FirstName, table1.MidName, table1.LastName, table2.CourseCode, " +
                "table2.TeachingScheduleId, table2.TeachingDate\r\nFROM\r\n(\r\n    SELECT stu.*, rcb.IsAbsent, rcb.TeachingScheduleId\r\n    " +
                "FROM Students stu\r\n    INNER JOIN ROLL_CALL_BOOKS rcb ON stu.StudentId = rcb.StudentId\r\n) table1\r\nINNER JOIN\r\n(\r\n    " +
                "SELECT c.CourseId, c.CourseCode, cs.TeachingScheduleId, cs.TeachingDate\r\n    FROM COURSES c\r\n    " +
                "INNER JOIN COURSE_SCHEDULES cs ON c.CourseId = cs.CourseId\r\n) table2\r\nON table1.TeachingScheduleId = " +
                "table2.TeachingScheduleId\r\nWHERE CourseCode = @codeName and CONVERT(DATE, table2.TeachingDate) = @dateInput;";
            SqlParameter parameter1 = new SqlParameter("@dateInput", SqlDbType.VarChar);
            parameter1.Value = dateInput;
            SqlParameter parameter2 = new SqlParameter("@codeName", SqlDbType.VarChar);
            parameter2.Value = codeInput;
            DataTable dt = DAO.GetDataBySql(sql, parameter1, parameter2);
            return dt;
        }


        public static List<DateTime> GetCourseDates()
        {
            List<DateTime> courseDates = new List<DateTime>();
            // Assuming you have a connection object named 'connection' that is properly initialized
            string sql = "Select distinct Convert(date,TeachingDate) as TeachingDate from COURSE_SCHEDULES";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime courseDate = (DateTime)dr["TeachingDate"];
                courseDates.Add(courseDate);
            }
            return courseDates;
        }

        public static int UpdateIsAbsentValue(int studentId, int teachingScheduleId, bool isAbsent)
        {
            string sql = @"UPDATE [ROLL_CALL_BOOKS]
                          SET 
                            [IsAbsent] = @absent
                            WHERE StudentId = @stuId and TeachingScheduleId = @teachingId";
            SqlParameter param1 = new SqlParameter("@absent", SqlDbType.Int);
            param1.Value = isAbsent ? 1 : 0;
            SqlParameter param2 = new SqlParameter("@stuId", SqlDbType.Int);
            param2.Value = studentId;
            SqlParameter param3 = new SqlParameter("@teachingId", SqlDbType.Int);
            param3.Value = teachingScheduleId;
            return DAO.ExecuteSQL(sql, param1, param2, param3);
        }
    }
}
