using System;

namespace Day1_10_5_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.Input();
            int choice;
            Account account = new Account();
            do {
                choice = department.Menu();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Number of account is: {department.GetNumberOfAccount()}");
                        break;
                    case 2:
                        while (true)
                        {
                        account = new Account(department.InputString("Enter Username: ", "Username is not null"), department.InputString("Enter Password: ", "Password is not null"));
                        department.AddAccount(account);
                            if (department.InputString("Do you want continue add (Y/n): ", "Not empty. Enter again").ToLower().Equals("n")) break;
                        }
                        break;
                    case 3:
                        account.Username = department.InputString("Enter Username: ", "Username is not null");
                        department.RemoveAccount(account);
                        break;
                    case 4:
                        department.Display();
                        break;
                    case 5:
                        department.Sort();
                        Console.WriteLine("List account after sort by username: ");
                        department.Display();
                        break;
                    case 6:
                        Console.WriteLine("Developing....!!!!");
                        break;
                }
            } while(choice !=7);
        }
    }
}
