using Microsoft.AspNetCore.Mvc;
using Question2.Models;

namespace Question2.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult ListByEmployee()
        {
            using (var context = new PE_PRN_23SumContext())
            {
                List<Employee> employees = context.Employees.ToList();
                List<Order> orders = context.Orders.ToList();


                return View(orders);
            }

            
        }
    }
}
