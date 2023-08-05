using Microsoft.AspNetCore.Mvc;
using Q3.Logic;
using Q3.Models;

namespace Q3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            var context = new PeFall21B5Context();

            List<Employee> employeeList = context.Employees.ToList();
            return View(employeeList);
        }

        public IActionResult Delete(int id) {
            EmployeeManage.Delete(id);
            Console.WriteLine(id);
            return Redirect("/Employee/List");
        }

    }
}
