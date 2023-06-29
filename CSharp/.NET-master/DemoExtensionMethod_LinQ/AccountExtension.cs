using SE1422;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod_LinQ
{
    static class AccountExtension
    {
        static public void Display(this Account a)
        {
            Console.WriteLine(a);
        }
        static public void Display(this List<Account> a)
        {
            foreach (Account a2 in a)
                Console.WriteLine(a2);
        }
    }
}
