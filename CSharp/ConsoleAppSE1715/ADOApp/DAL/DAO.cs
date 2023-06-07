using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace ADOApp.DAL
{
    internal class DAO
    {
        /*public static SqlConnection GetConnection()
        {
            String ConnectStr = "server = DESKTOP-2EP69KG\\MSSQLSERVER2019; database = AP; user = sa; password = 123456";
            return new SqlConnection(ConnectStr);
        }*/

        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string connectionString = config.GetConnectionString("MyConStr");
            return new SqlConnection(connectionString);
        }


        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length != 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
