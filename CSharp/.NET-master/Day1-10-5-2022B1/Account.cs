using System;
using System.Collections.Generic;

namespace SE1422
{
    public class Account
    {
        protected string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        protected string password;
        public string Password { 
            get { return password; }
            set { password = value; }
        }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public virtual void Input()
        {
            Console.Write("Username: ");
            username = Console.ReadLine().Trim();
            Console.Write("Password: ");
            password = Console.ReadLine().Trim();
        }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   Username == account.Username;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username);
        }

        public override string ToString()
        {
            //return $"Account: {username} - {password}";
            return $"Account|{username}|{password}";
        }

    }
    class UsernameCompare : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Username.CompareTo(y.Username);
        }
    }
    class DataTypeCompare : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name);
        }
    }
}
