using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Q1.DAL
{
    internal class ADO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string connectionString = config.GetConnectionString("MyConStrs");
            return new SqlConnection(connectionString);
        }
        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            // Create a new SqlCommand with the SQL query and a SqlConnection obtained from the GetConnection method
            SqlCommand cmd = new SqlCommand(sql, GetConnection());

            // Add the parameters to the command if any parameters are provided
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }

            // Create a new SqlDataAdapter and associate it with the SqlCommand
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // Create a new DataTable to hold the retrieved data
            DataTable dt = new DataTable();

            // Use the adapter to fill the DataTable with data from the query
            adapter.Fill(dt);

            // Return the populated DataTable
            return dt;
        }
    }
}
