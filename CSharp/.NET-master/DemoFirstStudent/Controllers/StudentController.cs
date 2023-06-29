
using DemoFirstStudent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoFirstStudent.Controllers
{
    public class StudentController : Controller
    {
        [BindProperty(SupportsGet = true)]
        public string Major { get; set; }
        public IActionResult List()
        {
            ViewData["Message"] = $"List of students in {Major}";
            return View();
        }
        public IActionResult Index()
        {
            ViewData["Message"] = $"List of students in {Major}";
            List<Student> students = new List<Student>();
            using (var context = new LAB2Context())
            {
                students = context.Students.Where(s => s.Major == Major).ToList();
            }
            ViewData["Students"] = students;
            return View("List");
        }
        public IActionResult Edit()
        {
            return View("Edit");
        }
        public IActionResult Add()
        {
            return View("Add");
        }
        public IActionResult Delete()
        {
            return View("Delete");
        }
    }
}
