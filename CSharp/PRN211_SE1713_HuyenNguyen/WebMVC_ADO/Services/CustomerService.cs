using Microsoft.Data.SqlClient;
using System.Data;

namespace WebMVC_ADO.Models
{
    public class CustomerService
    {
        static DataProvider d = new DataProvider();
        public CustomerService() { }
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> data = new List<Customer>();

            // danh sach Product
            string strSelect = "SELECT * FROM Customers";
            using (IDataReader dr = d.executeQuery2(strSelect))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string name = dr.GetString(1);
                    string dob = dr.GetDateTime(2).ToString();
                    string gender = dr.GetBoolean(3) ? "Male" : "Female";
                    string address = dr.GetString(4);
                    Customer c = new Customer();
                    c.ID = id;
                    c.Name = name;
                    c.Address = address;
                    c.Dob = dob;
                    c.Gender = gender;
                    data.Add(c);
                }
            }
            return data;
        }

        public static List<Customer> searchCustomer(string addressToSearch, string genderToSearch, string sortCriteria)
        {
            List<Customer> data = new List<Customer>();
            string strSelect = "SELECT * FROM Customers " +
                "WHERE Address LIKE '%' +  @addressToSearch + '%' " +
                "AND Gender = @genderToSearch " +
                "ORDER BY " + sortCriteria;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@addressToSearch",addressToSearch),
                new SqlParameter("@genderToSearch",genderToSearch),
                new SqlParameter("@sortCriteria",sortCriteria),
            };
            using (IDataReader dr = d.executeQuery2(strSelect, param))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string name = dr.GetString(1);
                    string dob = dr.GetDateTime(2).ToString();
                    string gender = dr.GetBoolean(3) ? "Male" : "Female";
                    string address = dr.GetString(4);
                    Customer c = new Customer();
                    c.ID = id;
                    c.Name = name;
                    c.Address = address;
                    c.Dob = dob;
                    c.Gender = gender;
                    data.Add(c);
                }
            }

            return data;
        }
    }
}
