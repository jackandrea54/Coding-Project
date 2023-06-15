using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab2.DAL
{
    internal class Dao
    {
        public static SqlConnection GetConnection()
        {
            string ConnectStr = "server = DESKTOP-2EP69KG\\MSSQLSERVER2019; database = LAB2; user = sa; password = 123456";
            return new SqlConnection(ConnectStr);
        }

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static int DeleteBySql(string sql, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            return cmd.ExecuteNonQuery();
        }
        public static int InsertBySql(string sql, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            int result = -1;
            try { 
                result = cmd.ExecuteNonQuery(); 
            }catch(Exception e){
                Console.WriteLine(e.StackTrace);
            }
            return result;
        }
        public static int UpdateBySql(string sql, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
