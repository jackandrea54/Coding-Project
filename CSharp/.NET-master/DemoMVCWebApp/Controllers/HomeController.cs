using Microsoft.AspNetCore.Mvc;

namespace DemoMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("test");
        }
        public string List()
        {
            return "Action result";
        }
        public void DoSomething()
        {

        }
        public string search(string q)
        {
            return $"test send form with name is {q}";
        }
    }
}
