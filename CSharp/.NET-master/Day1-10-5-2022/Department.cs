using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_10_5_2022
{
    internal class Department:IDisplayable
    {
        List<Account> accounts;
        //public string DepartmentName { get; set; }
        public Department()
        {
            accounts = new List<Account>();
        }
        public string DepartmentName { get; set; }
        public int GetNumberOfAccount() { return accounts.Count; }
        public void AddAccount(Account c) {
            if (accounts.Contains(c)) { Console.WriteLine("Account already exists"); return; } else { accounts.Add(c); Console.WriteLine($"Add account {c.Username} successfully"); }
        }
        public void RemoveAccount(Account c) {
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
            while (true) {
                Console.Write(message);
                string inputString = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputString)) return inputString;
                Console.WriteLine(error);
            }
            
        }
        public void Input() {
            DepartmentName = InputString("Enter Department Name:", "Department name is not null. Enter again");
            while (true)
            {
                Account account = new Account(InputString("Enter Username: ", "Username is not null"), InputString("Enter Password: ", "Password is not null"));
                AddAccount(account);
                if (InputString("Do you want continue add (Y/n): ", "Not empty. Enter again").ToLower().Equals("n")) return;
            }
        }
        public void Sort() { 
            accounts.Sort(new UsernameCompare());
        }
        public void SortByType() { }
        

        public void Display()
        {
            Console.WriteLine($"List Accounts in Department : {DepartmentName}");
            Console.WriteLine($"{"No",5}{"Username",15}{"Password",15}");
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"{i + 1,5}{accounts[i].Username,15}{accounts[i].Password,15}");
            }

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
                    if(num >=1 && num <= 7)
                    {
                        return num;
                    }
                    Console.WriteLine("Choice must in [1-7]: ");

                }catch {
                    Console.WriteLine("Choice must is number");
                }
            }
        }
    }
}
