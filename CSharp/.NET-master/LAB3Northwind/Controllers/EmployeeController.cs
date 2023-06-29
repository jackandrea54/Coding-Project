using LAB3Northwind.Helper;
using LAB3Northwind.Logics;
using LAB3Northwind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LAB3Northwind.Controllers
{
    public class EmployeeController : Controller
    {
        public static readonly NorthwindContext _context = new NorthwindContext();
        public int ITEMS_PER_PAGE = 12;
        [BindProperty(SupportsGet = true, Name = "page")]
        public int CurrentPage { get; set; }
        public int CountPages { get; set; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int id, int view)
        {
            List<Employee> empoloyees = EmployeeLogic.GetAllEmployee();
            if (id == 0)
            {
                int _totalOrder = _context.Orders.Count();
                CountPages = (int)_totalOrder / ITEMS_PER_PAGE;
                if (_totalOrder % ITEMS_PER_PAGE != 0)
                {
                    CountPages = CountPages + 1;
                }
            }
            if (id != 0)
            {
                if (view != 0)
                {
                    ITEMS_PER_PAGE = view;
                }
                int _totalOrder = _context.Orders.Where(m => m.EmployeeId == id).Count();
                CountPages = (int)_totalOrder / ITEMS_PER_PAGE;
                if (_totalOrder % ITEMS_PER_PAGE != 0)
                {
                    CountPages = CountPages + 1;
                }
            }
            if (CurrentPage < 1)
            {
                CurrentPage = 1;
            }
            if (CurrentPage > CountPages)
            {
                CurrentPage = CountPages;
            }
            ViewData["View"] = ITEMS_PER_PAGE;
            PagingHelper pagingHelper = new PagingHelper();
            pagingHelper.CurrentPage = CurrentPage;
            pagingHelper.CountPage = CountPages;
            ViewData["Paging"] = pagingHelper;
            List<Order> orders = EmployeeLogic.GetAllOrderByEmployess((CurrentPage - 1) * ITEMS_PER_PAGE + 1, ITEMS_PER_PAGE, id);
            ViewData["ListOrder"] = orders;
            return View(empoloyees);
        }

    }
}
