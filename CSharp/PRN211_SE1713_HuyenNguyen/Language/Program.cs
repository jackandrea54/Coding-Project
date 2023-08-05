namespace Language
{
    public class Program
    {
        static void Main(string[] args)
        {
            // tao menu 4 chuc nang va thuc hien cho den khi nhap 0
            while (true)
            {

                DisplayMenu();
                long option = GetInt(0, 6, "Enter an option: ", "Invalid option!");
                if (option == 0)
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                switch (option)
                {
                    case 1:
                        long num1 = GetInt(int.MinValue, int.MaxValue, "Enter an integer: ", "");
                        if (num1 % 2 == 0)
                        {
                            Console.WriteLine("n la so chan");
                        }
                        else
                        {
                            Console.WriteLine("n la so le");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        long num2 = GetInt(int.MinValue, int.MaxValue, "Enter an integer: ", "");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        //Practice: s la chuoi ho ten
                        // 1. Hien thi ho, ten, ten dem
                        string name = Console.ReadLine().ToLower().Trim();
                        name = MakeProper(name);
                        string[] words = name.Split(' ');
                        string middleName = "";
                        for (int i = 1; i < words.Length - 1; i++)
                        {
                            middleName += words[i] + " ";
                        }
                        middleName = middleName.Trim();
                        Console.WriteLine("Last name: " + words[0]);
                        Console.WriteLine("Middle name: " + middleName);
                        Console.WriteLine("First name: " + words[words.Length - 1]);
                        Console.WriteLine();
                        break;
                    case 6:
                        DemoList();
                        Console.WriteLine();
                        break;
                    default: 
                        Console.WriteLine(getLastName("Trieu Thach An"));
                        break;
                }

            }
        }

        private static void DemoList()
        {
            List<String> list = new List<String>()
            {
                "Nguyen Thi Khanh Huyen",
                "Hoang Mai Phuong",
                "Khieu Minh Duc",
                "Pham Truong Giang",
                "Trieu Thach An",
                "Nguyen Thuc Thuy Tien"
            };
            Console.WriteLine("Danh sach ho ten:");
            foreach (String item in list)
            {
                Console.WriteLine(item);
            }

            //1. List ho Nguyen
            bool checkNguyen = false;
            Console.WriteLine("1. Nhung nguoi ho Nguyen: ");
            foreach (String item in list)
            {
                if (getFamilyName(item).Equals("Nguyen"))
                {
                    checkNguyen = true;
                    Console.WriteLine(item);
                }
            }
            if (!checkNguyen)
            {
                Console.WriteLine("Khong co ai ho Nguyen.");
            }


            //2.Tinh tong so ki tu trong ten cua nhung nguoi ma ho co so ki tu nho hon 6
            Console.WriteLine("2. Tong so ki tu trong ten cua nhung nguoi ma ho co so ki tu nho hon 6:");
            foreach (String item in list)
            {
                if (getFamilyName(item).Length < 6)
                {
                    Console.Write(item + ": ");
                    Console.Write(item.Length);
                    Console.WriteLine();
                }
            }

            //3.Hien thi nhung nguoi co ten bat dau boi ki tu "T"
            Console.WriteLine("3. Nhung nguoi co ten bat dau boi ki tu \"T\"");
            foreach (String item in list)
            {
                if (getLastName(item).StartsWith("T"))
                {
                    Console.WriteLine(item);
                }
            }


            //4.Ai la nguoi co ten dai nhat
            Console.Write("4. Nguoi co ten dai nhat:");
            int maxLength = 0;
            String maxName = "";
            foreach (String item in list)
            {
                if (maxLength < item.Length)
                {
                    maxLength = item.Length;
                    maxName = item;
                }
            }
            Console.WriteLine(maxName);


            /*
             * 1. Co ai ho Nguyen? Display
             * 2. Tinh tong so ki tu trong ten cua nhung nguoi ma ho co so ki tu nho hon 6
             * 3. Hien thi nhung nguoi co ten bat dau boi ki tu "T"
             * 4. Ai la nguoi co ten dai nhat
             * 
             */


        }


        static String getLastName(String name)
        {
            String[] words = name.Trim().Split(' ');
            return words[words.Length - 1];
        }


        static String getFamilyName(String name)
        {
            return name.Trim().Split(" ")[0];
        }

        static string MakeProper(string name)
        {
            string[] words = name.Trim().ToLower().Split(" ");
            name = "";
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if (words[i].Length != 0)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
                    name += words[i] + " ";
                }
            }
            return name.Trim();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Check parity");
            Console.WriteLine("2. Check if the number is prime");
            Console.WriteLine("3. Display all number ending with 3 within 0 and n");
            Console.WriteLine("4. Display the first n prime numbers");
            Console.WriteLine("4. String demo");
        }

        static long GetInt(int min, int max, string msg, string err)
        {
            long num;
            while (true)
            {
                Console.Write(msg);
                try
                {
                    num = long.Parse(Console.ReadLine());
                    if (num >= min || num <= max)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine(err);
                    }
                }
                catch
                {
                    Console.WriteLine(err);
                }
            }
        }

        static void DisplayFirstPrimes(int n)
        {
            int count = 0, current = 0;
            while (count < n)
            {
                if (IsPrime(current))
                {
                    Console.Write(" " + current);
                    count++;
                }
                current++;
            }
        }

        static void Display3End(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (i % 10 == 3)
                {
                    Console.Write(" " + i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}