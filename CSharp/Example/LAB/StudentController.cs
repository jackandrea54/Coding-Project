using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class StudentController
    {
        List<Student> students;

        public StudentController()
        {
            students = new List<Student>();
        }
        public void ReadStudentFromFile(String filename)
        {
            int countLine = 0;
            try
            {
                StreamReader reader = new StreamReader(filename);
                String line;
                Student st = new Student();

                while ((line = reader.ReadLine()) != null)
                {
                    countLine++;
                    try
                    {
                        Student student = st.ReadFromLine(line);
                        AddStudent(student);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + " in line " + countLine);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Can't found" + filename);
            }
            catch (Exception)
            {
                Console.WriteLine("Something error");
            }
        }
        public void AddStudent(Student student)
        {
            // check student if exist in list students then not add using linq
            if (students.Any(s => s.Equals(student)))
            {
                throw new ArgumentException($"Student ID: {student.Id} already exists");
            }
            else
            {
                students.Add(student);
            }
            //if (students.Find(x => x.Id == student.Id) == null)
            //{
            //    students.Add(student);
            //}
            //else
            //{
            //    throw new ArgumentException($"Student ID: {student.Id} already exists");
            //}
        }
        public List<Student> getAllStudent()
        {
            return students;
        }
        // find student by id
        public Student FindStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
            //return students.Select(s => s).Where(s => s.Id == id).FirstOrDefault();
        }
        // find list of students by name
        public List<Student> FindStudentsByName(string name)
        {
            return students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        // find list of students by major
        public List<Student> FindStudentsByMajor(string major)
        {
            return students.Where(s => s.Major.ToLower().Contains(major.ToLower())).ToList();
        }
        //find list of students has major and schoolarship greater than a number
        public List<Student> FindStudentsByMajorAndSchoolar(string major, float schoolarship)
        {
            return students.Where(s => s.Major.Equals(major, StringComparison.OrdinalIgnoreCase) && s.SchollarShip >= schoolarship).ToList();

        }
        // find list of students by year of birth
        public List<Student> FindStudentsByYearOfBirth(int year)
        {
            return students.Where(s => s.DateOfBirth.Year.Equals(year)).ToList();
        }
        // find list of students between two date of birth
        public List<Student> FindStudentsByDateOfBirth(DateTime start, DateTime end)
        {
            return students.Where(s => s.DateOfBirth >= start && s.DateOfBirth <= end).ToList();
        }
        // find list of students by YearAdmitted
        public List<Student> FindStudentsByYearAdmitted(int year)
        {
            return students.Where(s => s.YearAdmitted == year).ToList();
        }
        // find students has schollarship in min and max range
        public List<Student> FindStudentsHasSchollarship(int min, int max)
        {
            return students.Where(s => s.SchollarShip >= min && s.SchollarShip <= max).ToList();
        }

        public int Menu()
        {
            Console.WriteLine("1.Find student by id");
            Console.WriteLine("2.Find student by name");
            Console.WriteLine("3.Find student by major");
            Console.WriteLine("4.Find student by major and schoolarship");
            Console.WriteLine("5.Find student by year of birth");
            Console.WriteLine("6.Find student has date of birth between two date of birth");
            Console.WriteLine("7.Find student by year admitted");
            Console.WriteLine("8.Find student has schollarship in min and max range");
            Console.WriteLine("9.Display all student");
            Console.WriteLine("10.Exit");
            Console.Write("Enter your choice: ");
            while (true)
            {
                string number = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 10)
                    {
                        return num;
                    }
                    Console.WriteLine("Choice must in [1-10]: ");

                }
                catch
                {
                    Console.WriteLine("Choice must is number");
                }
            }
        }

    }
}
