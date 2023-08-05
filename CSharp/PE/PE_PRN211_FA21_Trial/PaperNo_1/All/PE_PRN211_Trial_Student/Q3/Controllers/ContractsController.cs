using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q3.Models;

namespace Q3.Controllers
{
    public class ContractsController : Controller
    {
        private readonly PE_PRN_Sum21Context _context;

        public ContractsController()
        {
            _context = new PE_PRN_Sum21Context();
        }

        // GET: Contracts
        public async Task<IActionResult> Index(int customerId)
        {
            List<SelectListItem> customers = new SelectList(_context.Customers, "CustomerId", "CustomerName", customerId).ToList();
            customers.Insert(0, new SelectListItem { Value = "0", Text = "Select customers" });
            ViewData["CustomerIds"] = customers;

            var pE_PRN_Sum21Context = _context.Contracts.Include(c => c.Customer).Include(c => c.Employee)
                .Where(c => c.CustomerId == (customerId==0?c.CustomerId:customerId));

            return View(await pE_PRN_Sum21Context.ToListAsync());
        }
 
        private bool ContractExists(int id)
        {
            return _context.Contracts.Any(e => e.Id == id);
        }
    }
}
