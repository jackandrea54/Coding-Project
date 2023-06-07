using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class EmployeeController
    {
        List<Employee> employees;

        public EmployeeController()
        {
            employees = new List<Employee>();
        }
        public void ReadEmployeeFromFile(String filename)
        {
            int countLine = 0;
            try
            {
                StreamReader reader = new StreamReader(filename);
                String line;
                Employee st = new Employee();

                while ((line = reader.ReadLine()) != null)
                {
                    countLine++;
                    try
                    {
                        Employee employee = st.ReadFromLine(line);
                        AddEmployee(employee);
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
        public void AddEmployee(Employee employee)
        {
            // check employee if exist in list employees then not add using linq
            if (employees.Any(e => e.Equals(employee)))
            {
                throw new ArgumentException($"Employee ID: {employee.id} already exists");
            }
            else
            {
                employees.Add(employee);
            }
            //if (employees.Find(x => x.Id == employee.Id) == null)
            //{
            //    employees.Add(employee);
            //}
            //else
            //{
            //    throw new ArgumentException($"Employee ID: {employee.Id} already exists");
            //}
        }
        public List<Employee> getAllEmployee()
        {
            return employees;
        }
        // find employee by id
        public Employee FindEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.id == id);
            //return employees.Select(e => e).Where(e => e.Id == id).FirstOrDefault();
        }
        // find list of employees by name
        public List<Employee> FindEmployeesByName(string name)
        {
            return employees.Where(e => e.name.ToLower().Contains(name.ToLower())).ToList();
        }
        // find list of students by position
        public List<Employee> FindEmployeesByPosition(string position)
        {
            return employees.Where(e => e.position.ToLower().Contains(position.ToLower())).ToList();
        }
        // find employees has base salary in min and max range
        public List<Employee> FindEmployeesHasBaseSalary(int min, int max)
        {
            return employees.Where(e => e.salary >= min && e.salary <= max).ToList();
        }

        // find employees has yearly salary in min and max range
        public List<Employee> FindEmployeesHasYearlySalary(int min, int max)
        {
            return employees.Where(e => e.salaryCalculation(e.salary, e.position) >= min && e.salaryCalculation(e.salary, e.position) <= max).ToList();
        }


        public int Menu()
        {
            Console.WriteLine("1.Find employee by id");
            Console.WriteLine("2.Find employee by name");
            Console.WriteLine("3.Find employee by position");
            Console.WriteLine("4.Find employee by base salary in min and max range");
            Console.WriteLine("5.Find employee by annual salary in min and max range");
            Console.WriteLine("6.Display all employee");
            Console.WriteLine("7.Exit");
            Console.Write("Enter your choice: ");
            while (true)
            {
                string number = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 7)
                    {
                        return num;
                    }
                    Console.WriteLine("Choice must in [1-7]: ");

                }
                catch
                {
                    Console.WriteLine("Choice must is number");
                }
            }
        }

    }
}
