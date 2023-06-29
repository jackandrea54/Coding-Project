using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fix this
namespace Day1_10_5_2022
{
    class Account
    {
        public string Username { get; set; }


        public string Password { get; set; }//public property get/set du lieu cho 1 field
                                            //ngam dinh co ten ko can quan tam


        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Account()
        {
           
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
            return 1;
        }
    }
}
