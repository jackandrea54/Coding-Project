using SE1422;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_10_5_2022
{
    public class UsernameDuplicateException : Exception
    {
        public UsernameDuplicateException(String e) : base() { Console.WriteLine(e); }
    }
    public class Department : IDisplayable
    {
        List<Account> accounts;
        //public string DepartmentName { get; set; }
        public Department()
        {
            accounts = new List<Account>();
        }
        public string DepartmentName { get; set; }
        public int GetNumberOfAccount() { return accounts.Count; }
        public void AddAccount(Account c)
        {
            if (accounts.Contains(c)) { throw new UsernameDuplicateException($"Account {c.Username} exist"); } else { accounts.Add(c); Console.WriteLine($"Add account {c.Username} successfully"); }
        }
        public void RemoveAccount(Account c)
        {
            if (accounts == null)
            {
                Console.WriteLine("List account is null"); return;
            }
            else
            {
                if (accounts.Contains(c)) { accounts.Remove(c); Console.WriteLine("Account has been remove"); } else { Console.WriteLine("Account does not exits"); return; }
            }

        }

        public string InputString(string message, string error)
        {
            while (true)
            {
                Console.Write(message);
                string inputString = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputString)) return inputString;
                Console.WriteLine(error);
            }

        }
        public void Input()
        {
            DepartmentName = InputString("Enter Department Name:", "Department name is not null. Enter again");
            while (true)
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Add Customer");
                string number = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 2)
                    {
                        if (num == 1)
                        {
                            Employee e = new Employee();
                            e.Input();
                            AddAccount(e);
                        }
                        if (num == 2)
                        {
                            Customer e = new Customer();
                            e.Input();
                            AddAccount(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choice must in [1-2]: ");
                    }
                }
                catch
                {
                    Console.WriteLine("Choice must is number");
                }
                if (InputString("Do you want continue add (Y/n): ", "Not empty. Enter again").ToLower().Equals("n")) return;
            }
        }
        public void Sort(object sortByUsername)
        {
            accounts.Sort(new UsernameCompare());
        }
        public void SortByType()
        {
            //accounts.Sort(new DataTypeCompare());
            accounts.Sort();
        }
        public void Display()
        {
            Console.WriteLine($"List Accounts in Department : {DepartmentName}");
            //Console.WriteLine($"{"No",5}{"Username",15}{"Password",15}");
            for (int i = 0; i < accounts.Count; i++)
            {
                //Console.WriteLine($"{i + 1,5}{accounts[i].Username,15}{accounts[i].Password,15}");
                Console.WriteLine(accounts[i]);
            }

        }
        public void ReadFromFile(String FileName)
        {

            try
            {
                StreamReader reader = new StreamReader(FileName);
                String[] departmentName = reader.ReadLine().Split(":");
                if (departmentName.Length == 2 && string.Equals(departmentName[0].Trim(), "department", StringComparison.OrdinalIgnoreCase))
                {
                    DepartmentName = departmentName[1].Trim();
                }
                else
                {
                    Console.WriteLine("Wrong format department name");
                    return;
                }
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] temp = line.Trim().Split("|");
                    if (temp.Length == 3 && temp[0].Trim().Equals("account", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Account account = new Account();
                            account.Username = temp[1].Trim();
                            account.Password = temp[2].Trim();
                            AddAccount(account);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine($"{temp[1].Trim()} error row");
                        }
                    }
                    if (temp.Length == 5 && temp[0].Trim().Equals("employee", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Employee employee = new Employee();
                            employee.Username = temp[1].Trim();
                            employee.Password = temp[2].Trim();
                            employee.Salary = Convert.ToDouble(temp[3].Trim());
                            employee.Role = temp[4].Trim();
                            AddAccount(employee);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"{temp[1].Trim()} error parse salary");
                        }
                    }
                    if (temp.Length == 5 && temp[0].Trim().Equals("customer", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Customer customer = new Customer();
                            customer.Username = temp[1].Trim();
                            customer.Password = temp[2].Trim();
                            customer.Name = temp[3].Trim();
                            customer.DOB = DateTime.ParseExact(temp[4], "dd MMM yyyy", null);
                            AddAccount(customer);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"{temp[1].Trim()} error parse date");
                        }
                    }
                }
                //writer.Close();
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found - Message:" + e.Message);
            }
            catch (UsernameDuplicateException e)
            {
            }
        }
        public void WriteFromFile(string FileName)
        {
            try
            {

                StreamWriter writer = new StreamWriter(FileName, append: true);
                writer.WriteLine($"Department : {DepartmentName}");
                foreach (Account account in accounts)
                {
                    writer.WriteLine(account.ToString());
                }
                Console.WriteLine($"Write {accounts.Count()} account to {DepartmentName}");
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something error");
            }

        }
        public static int SortByUsername(Account x, Account y)
        {
            return x.Username.CompareTo(y.Username);
        }

        public void SortUsingDelegate()
        {
           accounts.Sort((a,b) => a.Username.CompareTo(b.Username));

        }
        public int Menu()
        {
            Console.WriteLine("1.Get number of account");
            Console.WriteLine("2.Add Account");
            Console.WriteLine("3.Remove account");
            Console.WriteLine("4.Display account");
            Console.WriteLine("5.Sort account by username");
            Console.WriteLine("6.Sort account by type");
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
