using System.Collections.Generic;
using System.Linq;
using LAB3Northwind.Models;

namespace LAB3Northwind.Logics
{
    public class EmployeeLogic
    {
        public static readonly NorthwindContext _context = new NorthwindContext();
        //get all Employees
        public static List<Employee> GetAllEmployee()
        {
            return _context.Employees.ToList();
        }
        // get all order of employee
        public static List<Order> GetAllOrderByEmployess(int Offset, int Count, int id)
        {
            List<Order> orders = new List<Order>();
            if (id == 0)
            {
                orders = _context.Orders.Skip(Offset - 1).Take(Count).ToList();
            }
            else
            {
                orders = _context.Orders.Where(m => m.EmployeeId == id).Skip(Offset - 1).Take(Count).ToList();
            }

            List<Employee> employees = _context.Employees.Where(m => m.EmployeeId == id).ToList();
            var customer = from o in orders
                           join e in _context.Customers
                           on o.CustomerId equals e.CustomerId
                           select e;
            List<Customer> customers = customer.ToList();
            return orders;
        }
    }
}
