using System.Net;
using System.Runtime.CompilerServices;

namespace DelegateEvent
{
    public class Program
    {
        //khai bao delegate
        delegate void MyDelegate1(int a, int b); //tro toi mot ham void co 2 tham so kieu int
        delegate int MyDelegate2(int a, int b);
        delegate string MyDelegate3(string a);
        static void Main(string[] args)
        {
            //khi chua su dung delegate
            Console.WriteLine("Not use delegate");
            Tong(3, 4);
            UCLN(3, 4);
            DienTich(3, 4);

            //khi su dung delegate
            Console.WriteLine("Use delegate");

            // cach tao ra delegate - cach 1
            MyDelegate1 dg = new MyDelegate1(Tong);
            dg += UCLN;
            dg += DienTich;
            dg(3, 4);

            dg -= DienTich;
            dg(12, 4);

            // cach tao ra delegate - cach 2
            MyDelegate2 dg2 = new MyDelegate2(Hieu);
            Console.WriteLine("a - b = " + dg2(5, 4));

            MyDelegate2 dg3 = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine("a - b = " + dg3(5, 4));

            //bien doi delegate tren thanh Lambda
            MyDelegate2 dg4 = (int a, int b) =>
            {
                return a - b;
            };
            Console.WriteLine("a - b = " + dg4(5, 4));

            //bien doi delegate tren thanh 
            MyDelegate2 dg5 = (int a, int b) => a - b;
            Console.WriteLine("a - b = " + dg5(5, 4));

            //mot vi du khac ve lambda
            MyDelegate3 dg6 = str => str.Substring(0, 3);
            Console.WriteLine(dg6("fpt university"));
        }

        public static void Tong(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }

        public static void UCLN(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m -= n;
                }
                else
                {
                    n -= m;
                }
            }
            Console.WriteLine("UCLN = " + m);
        }

        public static void DienTich(int x, int y)
        {
            Console.WriteLine("S = " + (x * y));
        }

        public static int Hieu(int x, int y)
        {
            return x - y;
        }
    }
}