using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    //Dinh nghia controller co ten la Home
    public class HomeController : Controller
    {
        //Dinh nghia action Index cua controller Home
        public IActionResult Index()
        {
            return View("Views/Default.cshtml");
        }

        public IActionResult List()
        {
            return View(); //Return View mac dinh cua action List
        }

        public void Add()
        {

        }

        public void Remove()
        {

        }



        public String Show()
        {
            return "Action show";
        }
    }
}
