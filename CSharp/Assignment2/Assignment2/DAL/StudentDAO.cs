using ADOApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace ADOApp.DAL
{
    internal class StudentDao
    {
        public static List<Student> GetAllStudent()
        {
            string sql = "select * from Students";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()));
            return students;
        }
        public static List<Student> GetStudentById(int StudentId)
        {
            string sql = "select * from Students where StudentId = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            //SqlParameter parameter2 = null;
            parameter1.Value = StudentId;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count == 0) return null;
            List<Student> students = new List<Student>();
            //DataRow dr = dt.Rows[0];
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student(
                Convert.ToInt32(dr["StudentId"]),
                dr["Roll#"].ToString(),
                dr["FirstName"].ToString(),
                dr["MidName"].ToString(),
                dr["LastName"].ToString()));
            return students;
        }

        public static List<Student> GetStudentByName(String inputName)
        {
            string sql = "select * from Students where FirstName like @name OR MidName like @name " +
                                                                            "OR LastName like @name";
            SqlParameter parameter1 = new SqlParameter("@name", DbType.String);
            parameter1.Value = "%" + inputName + "%";
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count == 0) return null;
            List<Student> students = new List<Student>();
            //DataRow dr = dt.Rows[0];
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student(
                Convert.ToInt32(dr["StudentId"]),
                dr["Roll#"].ToString(),
                dr["FirstName"].ToString(),
                dr["MidName"].ToString(),
                dr["LastName"].ToString()));
            return students;
        }

        public static int UpdateStudent(Student stu)
        {
            string sql = @"update Students set
                            FirstName = @fname,
                            MidName = @mname,
                            LastName = @lname
                            where StudentId = @id";
            SqlParameter param1 = new SqlParameter("@fname", SqlDbType.VarChar);
            param1.Value = stu.FirstName;
            SqlParameter param2 = new SqlParameter("@mname", SqlDbType.VarChar);
            param2.Value = stu.MidName;
            SqlParameter param3 = new SqlParameter("@lname", SqlDbType.VarChar);
            param3.Value = stu.LastName;
            SqlParameter param4 = new SqlParameter("@id", SqlDbType.Int);
            param4.Value = stu.StudentId;
            return DAO.ExecuteSQL(sql, param1, param2, param3, param4);
        }

        public static int DeleteStudent(int StudentId)
        {
            string sql = @"Delete from Students where StudentId = @id";
            SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
            param1.Value = StudentId;
            return DAO.ExecuteSQL(sql, param1);
        }
    }
}
