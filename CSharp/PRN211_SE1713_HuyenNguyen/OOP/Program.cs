namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va khoi tao mot list teacher
            List<Teacher> data = new List<Teacher>() {
                new FullTime("T01", "Nguyen Van A", 2.0),
                new PartTime("T02", "Tran Van B", 10),
                new FullTime("T03", "Pham Thi C", 1.5)
            };

            IManager manager = new Manager(data);

            while (true)
            {
                Console.WriteLine("1. Input list teacher");
                Console.WriteLine("2. Show list teacher");
                Console.WriteLine("3. Count part-time teacher who has >10 slots");
                Console.WriteLine("4. Count total part-time slots");
                Console.WriteLine("5. Sort teachers by salary");
                Console.WriteLine("6. Show teachers whose name is T*");
                Console.WriteLine("7. Show teachers with Heso < 3");
                Console.WriteLine("8. Save File");
                Console.WriteLine("9. Load File");
                Console.WriteLine("-1. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case -1:
                        Console.WriteLine("Bye");
                        break;
                    case 1:
                        Console.Write("Enter size: ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        manager.InputList(size);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("List teachers: ");
                        manager.OutputList();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("There are " + manager.CountPT10() + " part-time teachers with >10 slots.");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("There are " + manager.GetTotalPTSlot() + " part-time slots.");
                        Console.WriteLine();
                        break;
                    case 5:
                        manager.SortBySalary();
                        Console.WriteLine("Teacher list after sorting by salary (ascending): ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Teachers whose name starts with T: ");
                        manager.ShowTInfo();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Teachers with Heso < 3: ");
                        manager.Show3();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Save to file");
                        manager.SaveFile();
                        break;
                    case 9:
                        Console.WriteLine("Load from file");
                        manager.LoadFile();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                if (option == -1)
                {
                    break;
                }
            }
        }
    }
}