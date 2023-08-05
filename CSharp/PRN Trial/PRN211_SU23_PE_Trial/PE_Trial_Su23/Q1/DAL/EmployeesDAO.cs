using Q1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DAL
{
    internal class EmployeesDAO
    {
        public static List<Employees> GetDataEmployee()
        {
            string sql = "select e.Id, e.Name, e.Dob, e.Sex, e.Position, e.Department, d.Name as [DepartmentName] from Employee e join Department d on e.Department = d.Id";
            DataTable dataTable = ADO.GetDataBySql(sql);
            List<Employees> employees = new List<Employees>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int id = Convert.ToInt32(dr["Id"]);
                string name = dr["Name"].ToString();
                DateTime dob = DateTime.Parse(dr["Dob"].ToString()); // Convert string to DateTime
                string formattedDob = dob.ToString("dd-MM-yyyy");
                string sex = dr["Sex"].ToString();
                string position = dr["Position"].ToString();
                int department = Convert.ToInt32(dr["Department"]);
                string departmentName = dr["DepartmentName"].ToString();

                employees.Add(new Employees(id, name, formattedDob, sex, position, department, departmentName));
            }
            return employees;
        }

        public static List<Employees> GetPosition() {
            string sql = "select distinct e.Position from Employee e"; // Replace with your actual SQL query

            DataTable dataTable = ADO.GetDataBySql(sql);
            List<Employees> listPosition = new List<Employees>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string position = dr["Position"].ToString();

                listPosition.Add(new Employees(position));
            }
            return listPosition;
        }

        

}
}
