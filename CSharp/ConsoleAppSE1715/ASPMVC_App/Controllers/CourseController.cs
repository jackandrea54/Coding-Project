using ASPMVC_App.Models;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_App.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List(int id)
        {
            using (var context = new APContext())
            {
                List<Course> courses= null;
                if (id == 0)
                {
                    courses = context.Courses.ToList();
                }
                else
                {
                    courses = context.Courses.Where(x => x.SubjectId == id).ToList();
                }
                List<Subject> subjects = context.Subjects.ToList();
                ViewBag.subjects = subjects;
                return View(courses);
            }
        }

        public IActionResult Detail(int id)
        {
            using(var context = new APContext()) 
            {
                Course course = context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                ViewBag.instructor = context.Instructors.Where(x => x.InstructorId == course.InstructorId).FirstOrDefault();
                ViewData["subjectName"] = context.Subjects.Where(x => x.SubjectId == course.SubjectId).FirstOrDefault().SubjectName;
                return View(course);
            }
        }

        public IActionResult Edit(int id)
        {
            using (var context = new APContext())
            {
                Course course = context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                ViewBag.instructor = context.Instructors.ToList();
                ViewBag.term = context.Terms.ToList();
                ViewBag.campus = context.Campuses.ToList();
                ViewBag.subject = context.Subjects.ToList(); //gui sang view
                return View(course);
            }
        }


        [HttpPost]
        public IActionResult Edit(Course course)
        {
            using(var context = new APContext())
            {
                Course old = context.Courses.Where(x => x.CourseId == course.CourseId).FirstOrDefault();
                old.CourseCode = course.CourseCode;
                old.CourseDescription = course.CourseDescription;
                old.CampusId = course.CampusId;
                old.InstructorId = course.InstructorId;
                old.TermId = course.TermId;
                old.SubjectId = course.SubjectId;
                context.SaveChanges();
                return Redirect("/Course/List");
            }
        }

        public IActionResult Delete(int id)
        {
            using (var context = new APContext())
            {
                Course c = context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                if (c != null)
                {
                    List<CourseSchedule> schedule = context.CourseSchedules.Where(x => x.CourseId == id).ToList();
                    foreach (CourseSchedule i in schedule)
                    {
                        List<RollCallBook> temp = context.RollCallBooks.Where(x => x.TeachingScheduleId == i.TeachingScheduleId).ToList();
                        context.RollCallBooks.RemoveRange(temp);
                    }

                    context.CourseSchedules.RemoveRange(schedule);
                    List<StudentCourse> x = context.StudentCourses.Where(x => x.CourseId == id).ToList();
                    context.StudentCourses.RemoveRange(x);
                    
                    context.SaveChanges();
                }
                return Redirect("/Course/List");
            }
        }
    }
}
