using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADOApp.DAL
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            String ConnectStr = "server = DESKTOP-2EP69KG\\MSSQLSERVER2019; database = AP; user = sa; password = 123456";
            return new SqlConnection(ConnectStr);
        }

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length != 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(); //Khoi tao sqlAdapter
            adapter.SelectCommand = cmd; //Dat command
            DataTable dt = new DataTable(); //Khoi tao DataTable de chua cac Record
            adapter.Fill(dt); //Fill cac Record vao DataTable theo lenh sql da duoc dat
            return dt;
        }

        //danh cho cac cau sql insert, delete, update, goi thuc thi stored procedure
        public static int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int k = -1;
            try
            {
                k = command.ExecuteNonQuery();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return k;
            }

            command.Connection.Close();
            return k;
        }
    }
}
