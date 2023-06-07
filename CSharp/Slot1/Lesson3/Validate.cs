using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Validate
    {
        public static int getInt(String msg, int min, int max)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    number = Convert.ToInt32(Console.ReadLine);
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    Console.WriteLine($"Please input number in range {min} to {max}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong number format");
                }
            }
        }

        public static String getString(String msg, String REGEX)
        {
            do
            {
                Console.WriteLine(msg);
                String str = Console.ReadLine();
                if (Regex.Match(str, REGEX).Success)
                {
                    return str;
                }
                Console.WriteLine("Your string is wrong format dumbass");
            } while (true);
        }
    }
}
