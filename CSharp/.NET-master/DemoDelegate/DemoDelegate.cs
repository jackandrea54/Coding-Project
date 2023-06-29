using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate_Lambda
{
   class DemoDelegate
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("Add Function");
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            Console.WriteLine("Sub Function");
            return a - b;
        }
        public static void DemoBasicDelegate()
        {
            Caculation c; // khai bao c la 1 object delegate thuoc ve kieu caculation
            //c = new Caculation(Add);
            c = Add;
            c -= Sub;
            int k = c(5, 4); // tuong duong goi add(5,4)
            Console.WriteLine($"k ={k}");

            
        }
    }
}
