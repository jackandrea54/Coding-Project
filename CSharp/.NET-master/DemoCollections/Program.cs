using System;
using System.Collections.Generic;
using System.Collections;
using SE1422;
using Day1_10_5_2022;

namespace DemoCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Account("va","va"));
            list.Add(new Employee("va","va",2000,"admin"));

            Account a = (Account)list[0];

            List<Account> list2 = new List<Account>();
            list2.Add(new Account("test","test"));

            Account b = list2[0];
            Console.WriteLine(b);

        }
    }
}
