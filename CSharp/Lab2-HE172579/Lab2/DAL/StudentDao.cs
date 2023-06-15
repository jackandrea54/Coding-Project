﻿using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab2.DAL
{
    internal class StudentDao
    {
        public static List<Student> GetAllStudents() 
        {
            string sql = "select * from Student";
            DataTable dt = Dao.GetDataBySql(sql);
            List<Student> students = new List<Student>();

            string? gender;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToBoolean(dr["Gender"]))
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                students.Add(new Student(
                    //Convert.ToInt32(dr["StudentId"]),

                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    gender,
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Major"].ToString(),
                    Convert.ToInt16(dr["Scholarship"]),
                    Convert.ToBoolean(dr["Active"])
                    ));
            }
            return students ;
                    
        }

        public static List<Student> GetStudentsByMajor(String majorCode)
        {
            string sql = @"select * from Student where Major = @code";
            SqlParameter majorCo = new SqlParameter("@code", DbType.String);
            majorCo.Value = majorCode;
            DataTable dt = Dao.GetDataBySql(sql, majorCo);
            List<Student> students = new List<Student>();

            string? gender;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToBoolean(dr["Gender"]))
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                students.Add(new Student(
                    //Convert.ToInt32(dr["StudentId"]),

                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    gender,
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Major"].ToString(),
                    Convert.ToInt16(dr["Scholarship"]),
                    Convert.ToBoolean(dr["Active"])
                    ));
            }
            return students;

        }

        public static Student? GetStudent(int StudentId)
        {
            string sql = "select * from Student where StudentId = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = StudentId;
            DataTable dt = Dao.GetDataBySql(sql, parameter1);
            if (dt != null)
            {
                return null;
            }
            else
            {
                string? gender;
                DataRow dr = dt.Rows[0];
                if (Convert.ToBoolean(dr["Gender"]))
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                return new Student(
                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    gender,
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Major"].ToString(),
                    Convert.ToInt16(dr["Scholarship"]),
                    Convert.ToBoolean(dr["Active"])
                    );
            }
        }



        public static void DeleteStudent(string studentId)
        {
            string sql = "delete from Student where Id = @id";
            SqlParameter stdId = new SqlParameter("@id", DbType.Int32);
            stdId.Value = studentId;
            Dao.DeleteBySql(sql, stdId);
        }

        public static void UpdateStudent(Student std)
        {
            string sql = "update Student set Name = @name," +
                "                            Gender = @gender," +
                "                            Dob = @dob," +
                "                            Major = @major," +
                "                            Scholarship = @scholarship," +
                "                            Active = @active" +
                " where Id = @stdId";
            SqlParameter stdId = new SqlParameter("@stdId", DbType.String);
            SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
            SqlParameter gender = new SqlParameter("@gender", SqlDbType.Bit);
            SqlParameter dob = new SqlParameter("@dob", DbType.Date);
            SqlParameter major = new SqlParameter("@major", DbType.String);
            SqlParameter scholarship = new SqlParameter("@scholarship", SqlDbType.Float);
            SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);


            stdId.Value = std.StudentId;
            name.Value = std.Name;
            if (std.Gender != null && std.Gender.Equals("Male"))
            {
                gender.Value = 0;
            }
            else
            {
                gender.Value = 1;
            }
            dob.Value = std.DOB;
            major.Value = std.Major;
            scholarship.Value = std.Scholarship;
            if (std.Active != null && std.Active == true)
            {
                active.Value = 1;
            }
            else
            {
                active.Value = 0;
            }
            Dao.UpdateBySql(sql, stdId, name, gender, dob, major, scholarship, active);
        }



        public static int AddStudent(Student std)
        {
            string sql = "insert into Student values (" +
                "                            @stdId," +
                "                            @name," +
                "                            @gender," +
                "                            @dob," +
                "                            @major," +
                "                            @scholarship," +
                "                            @active)";
            SqlParameter stdId = new SqlParameter("@stdId", DbType.String);
            SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
            SqlParameter gender = new SqlParameter("@gender", SqlDbType.Bit);
            SqlParameter dob = new SqlParameter("@dob", DbType.Date);
            SqlParameter major = new SqlParameter("@major", DbType.String);
            SqlParameter scholarship = new SqlParameter("@scholarship", SqlDbType.Float);
            SqlParameter active = new SqlParameter("@active", SqlDbType.Bit);


            stdId.Value = std.StudentId;
            name.Value = std.Name;
            if (std.Gender != null && std.Gender.Equals("Male"))
            {
                gender.Value = 0;
            }
            else
            {
                gender.Value = 1;
            }
            dob.Value = std.DOB;
            major.Value = std.Major;
            scholarship.Value = std.Scholarship;
            active.Value = std.Active;
            int result = Dao.InsertBySql(sql, stdId, name, gender, dob, major, scholarship, active);
            return result;
        }
    }
}
