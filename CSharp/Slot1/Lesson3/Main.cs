using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2;

namespace Lesson3
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            List<Course> list = new List<Course>();
            Boolean flag = true;
            while (flag)
            {
                String choice;
                Console.WriteLine("\nChoice 1: Add Course. Input \"C\"" +
                    "\nChoice 2: Add Onlince Course. Input\"OC\"" +
                    "\nChoice 3: Find courses in between start and end date. Input \"F\"" +
                    "\nChoice 4: Sort all Course by Title. Input \"S\"" +
                    "\nChoice 5: Exit. Input \"E\"");
                choice = Console.ReadLine().ToUpper();
                switch (choice) {
                    case "C":
                        Course course = new Course();
                        course.Input();
                        list.Add(course);
                        break;
                    case "OC":
                        OnlineCourse onCourse = new OnlineCourse();
                        onCourse.Input();
                        list.Add(onCourse);
                        break;
                    case "F":
                        Console.WriteLine("Input startDate: ");
                        DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Input endDate: ");
                        DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                        Search(startDate, endDate,list);
                        break;
                    case "S":
                        List<Course> listTemp = list.ToList();
                        listTemp.Sort();
                        DisplayList(listTemp);
                        break;
                    case "E":
                        flag = false;
                        break;
                }

                if(choice.Equals("C") || choice.Equals("OC")) 
                {
                    DisplayList(list); 
                }
                
            }
        }

        public static void DisplayList(List<Course> list)
        {
            Console.WriteLine("List of courses: ");
            foreach(Course c in list)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public static void Search(DateTime startDate, DateTime endDate, List<Course> list)
        {
            Console.WriteLine("Danh sach course tim duoc la: ");
            foreach(Course c in list)
            {
                if(c.ngayBD >= startDate && c.ngayBD <= endDate)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }

    internal class Course : IComparable
    {
        public int Id;
        public String Title;
        public DateTime ngayBD;

        public Course() { }

        public int CompareTo(object? obj)
        {
            if (obj == null) { return 1; }
            Course c = (Course) obj;
            return Title.CompareTo(c.Title);
        }

        public virtual void Input()
        {
            Console.WriteLine("Input ID: ");
            /*Int32.TryParse(Console.ReadLine(), out Id);*/
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Title: ");
            Title = Console.ReadLine();
            Console.WriteLine("Ngay bat dau khoa hoc: ");
            /* DateTime.TryParse(Console.ReadLine(), out ngayBD);*/
            /*ngayBD = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);*/
            ngayBD = Convert.ToDateTime(Console.ReadLine());
        }

        public override string? ToString()
        {
            return $"ID: {Id} - Title: {Title} - Ngay BD: {ngayBD}";
        }

    }

    class OnlineCourse : Course {

        public String Meet;


        public OnlineCourse() { }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap link meet: ");
            Meet = Console.ReadLine();
        }

        public override string? ToString()
        {
            return base.ToString() + $" - Link meet:  {Meet}";
        }
    }
}
