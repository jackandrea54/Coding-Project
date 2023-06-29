using SE1422;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoExtensionMethod_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>
            {
                new Account("u1","12345"),
                new Account("u2","12s"),
                new Account("u12121","12s"),
                new Account("u1212122","12s"),
                new Account("u12122","12s"),
                new Account("u12122","12s")
            };
            Console.WriteLine("DEMO FIRST");
            list.FirstOrDefault(x => x.Username.Length == 6).Display();
            //list.Last(x => x.Username.Length == 6).Display();

            Console.WriteLine("DEMO WHERE");
            list.Where(x => x.Username.Contains("1")).ToList().Display();

            Console.WriteLine("DEMO SELECT");
            list.Where(x => x.Username.Contains("1"))
                .Select(y => y.Username)
                .Distinct()
                .OrderBy(x => x)
                .ToList()
                .ForEach(a => Console.WriteLine(a));

            

        }
    }
}
