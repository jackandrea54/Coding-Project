using Q3.Models;

namespace Q3.Logic
{
    public class EmployeeManage
    {
        public static void Delete(int id)
        {
            using (var context = new PeFall21B5Context())
            {
                List<Employee> employeeList = context.Employees.ToList();
                Employee employee = context.Employees.Where(x => x.Id == id).FirstOrDefault();
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}
