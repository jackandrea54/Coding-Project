using Day1_10_5_2022;
using SE1422;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_10_5_2022B1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Department department = new Department();
            department.ReadFromFile(@"D:\Semester 5\PRN211\Day1-10-5-2022\Day1-10-5-2022B1\department.txt");
            department.SortUsingDelegate();
            department.Display();
            department.WriteFromFile(@"D:\Semester 5\PRN211\Day1-10-5-2022\Day1-10-5-2022B1\departmentOut.txt");
            //department.DepartmentName = "IT";
            //accounts.Add(new Account("trungnb", "123456"));
            //accounts.Add(new Employee("hangnt", "123456", 1200, "admin"));
            //accounts.Add(new Account("annb", "123456"));
            //accounts.Add(new Account("vuongvt", "123456"));
            //accounts.Add(new Customer("thaonh", "1234", "Nguyen Huong Thao", DateTime.ParseExact("12 Aug 2000", "dd MMM yyyy", null)));
            //accounts.Add(new Employee("hangnt", "123456", 1200, "admin"));
            //writer.WriteLine($"Department: { department.DepartmentName}");
            //writer.Close();





            //Console.WriteLine(new Customer("123", "123", "123", DateTime.Parse("2000/08/12")));
            //Console.WriteLine(DateTime.ParseExact("12 Aug 2000", "dd MMM yyyy", null));
            //using (StreamReader file = new StreamReader(fileNameOut))
            //{
            //    string ln;
            //    Console.WriteLine(file.ReadLine().Split(":")[1].Trim());
            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Console.WriteLine(ln);
            //    }
            //}

        }
        //Console.WriteLine(DateTime.ParseExact("12/12/2020", "dd/MM/yyyy", null));
        //Account a = new Account("chilp", "123456");
        //Console.WriteLine("Account: ");
        //Console.WriteLine(a);
        //Console.WriteLine();

        //Employee e1 = new Employee("trungnb", "123457", 1200.4, "Admin");
        //Employee e2 = new Employee();
        //Console.WriteLine("Input Employee's info:");
        //e2.Input();
        //Console.WriteLine($"Employee: {e1}");
        //Console.WriteLine($"Employee: {e2}");
        //Console.WriteLine();

        //Customer c1 = new Customer("trungnb", "123457", "Bao Trung", new DateTime(1987, 12, 1));
        //Customer c2 = new Customer();
        //Console.WriteLine("Input Customer's info:");
        //c2.Input();
        //Console.WriteLine($"Customer: {c1}");
        //Console.WriteLine($"Customer: {c2}");
        //Console.ReadLine();
        //    Department department = new Department();
        //    department.Input();
        //    int choice;
        //    do
        //    {
        //        choice = department.Menu();
        //        switch (choice)
        //        {
        //            case 1:
        //                Console.WriteLine($"Number of account is: {department.GetNumberOfAccount()}");
        //                break;
        //            case 2:
        //                department.Input();
        //                break;
        //            case 3:
        //                Account account = new Account();
        //                account.Username = department.InputString("Enter Username: ", "Username is not null");
        //                department.RemoveAccount(account);
        //                break;
        //            case 4:
        //                department.Display();
        //                break;
        //            case 5:
        //                department.Sort();
        //                Console.WriteLine("List account after sort by username: ");
        //                department.Display();
        //                break;
        //            case 6:
        //                department.SortByType();
        //                Console.WriteLine("List account after sort by Type: ");
        //                department.Display();
        //                break;
        //        }
        //    } while (choice != 7);
        //}

    }
}
