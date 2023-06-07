using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.DataAccess
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConStr = @"server = DESKTOP-2EP69KG\MSSQLSERVER2019; database = Northwind; user = sa; password = 123456";
            return new SqlConnection(ConStr);
        }


        public static DataTable GetDataBySQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //danh cho cac cau sql insert, delete, update, goi thuc thi stored procedure
        public static int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int k= command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
