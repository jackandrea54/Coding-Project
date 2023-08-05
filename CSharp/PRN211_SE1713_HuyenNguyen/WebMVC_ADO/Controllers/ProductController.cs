using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebMVC_ADO.Models;
using WebMVC_ADO.Services;

namespace WebMVC_ADO.Controllers
{
    public class ProductController : Controller
    {
        DataProvider d = new DataProvider();

        public IActionResult Index()
        {
            List<Product> data = ProductService.getAllProducts();
            ViewBag.Data = data;
            return View();
        }
    }
}
