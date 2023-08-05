using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();
        // day la 1 action trong controller
        // action la 1 ham public co kieu tra ve la IActionResult
        public IActionResult Index(Student s)
        {
            // xu ly du lieu

            return View(s);
        }

        public IActionResult Show()
        {
            // truyen du lieu tu controller sang view 
            // c1: dung ViewData
            ViewData["Message"] = "Truyen du lieu bang ViewData: ";
            ViewData["Data"] = new Student()
            {
                Code = "SV01",
                Name = "Nguyen Van A",
                Age = 20
            };

            // c2: ViewBag
            ViewBag.Message1 = "Truyen du lieu bang ViewBag:";
            ViewBag.Data1 = new Student()
            {
                Code = "SV02",
                Name = "Nguyen Van B",
                Age = 21
            };

            // truyen 1 list student sang cho View
            ViewBag.students = students;

            // c3: Model



            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student s)
        {
            if (ModelState.IsValid)
            {
                // tao va truyen model thanh cong
                //ViewData["newStudent"] = new Student()
                //{
                //    Code = s.Code,
                //    Name = s.Name,
                //    Age = s.Age,
                //};
                students.Add(s);
                return RedirectToAction("Index", s);
            } else
            {
                // tao va truyen model that bai
                return View(s);
            }
            return View();
        }
    }

}
