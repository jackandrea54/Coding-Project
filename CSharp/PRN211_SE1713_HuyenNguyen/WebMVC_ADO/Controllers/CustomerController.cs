using Microsoft.AspNetCore.Mvc;
using WebMVC_ADO.Models;

namespace WebMVC_ADO.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            string addressToSearch = "Hà Nội";
            string genderToSearch = "1";
            string sortCriteria = "CusomterId";
            ViewBag.AddressToSearch = addressToSearch;
            ViewBag.GenderToSearch = genderToSearch;
            ViewBag.SortCriteria = sortCriteria;
            List<Customer> customers = CustomerService.GetAllCustomers();
            return View("CustomerList", customers);
        }

        [HttpPost]
        public IActionResult List(IFormCollection formCollection)
        {
            string addressToSearch = formCollection["addressToSearch"];
            string genderToSearch = formCollection["genderToSearch"];
            string sortCriteria = formCollection["sortCriteria"];
            if (sortCriteria == null)
            {
                sortCriteria = "CustomerId";
            }
            ViewBag.AddressToSearch = addressToSearch;
            ViewBag.GenderToSearch = genderToSearch;
            ViewBag.SortCriteria = sortCriteria;
            List<Customer> customers = CustomerService.searchCustomer(addressToSearch, genderToSearch, sortCriteria);
            return View("CustomerList", customers);
        }

    }
}
