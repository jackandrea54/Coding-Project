using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP
{
    public class Manager : IManager
    {
        public List<Teacher> Data { get; set; }

        public Manager()
        {

        }

        public Manager(List<Teacher> data)
        {
            this.Data = data;
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter code: ");
                String code = Console.ReadLine();
                Console.WriteLine("Enter name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Fulltime or Partime? (0 - Fulltime, 1 - Partime)");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0)
                {
                    Console.WriteLine("Enter heso: ");
                    double heso = Convert.ToDouble(Console.ReadLine());
                    Teacher t = new FullTime(code, name, heso);
                    Data.Add(t);
                }
                else
                {
                    Console.WriteLine("Enter slot: ");
                    int slot = Convert.ToInt32(Console.ReadLine());
                    Teacher t = new PartTime(code, name, slot);
                    Data.Add(t);
                }
            }
        }

        public void OutputList()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item);
                //if (item is PartTime)
                //{
                //    PartTime t = (PartTime)item;
                //    Console.WriteLine("Slot: " + t.Slot);
                //}

            }
        }

        public void ShowMaxList()
        {
            Console.WriteLine("List of teachers with the highest salary: ");
            double maxSalary = GetMaxSalary();
            foreach (var item in Data)
            {
                if (item.GetSalary() == maxSalary)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public int CountPT10()
        {
            Console.WriteLine("List of part-time teacher with >10 slots: ");
            int count = 0;
            foreach (var item in Data)
            {
                if (item is PartTime)
                {
                    PartTime t = (PartTime)item;
                    if (t.Slot > 10)
                    {
                        count++;
                        Console.WriteLine(t.Name + "\t" + t.Slot);
                    }
                }
            }
            return count;
        }

        public int GetTotalPTSlot()
        {
            int count = 0;
            foreach (var item in Data)
            {
                if (item is PartTime)
                {
                    PartTime t = (PartTime)item;
                    count += t.Slot;
                }
            }
            return count;
        }

        public void SortBySalary()
        {
            Data.Sort(new TeacherComparer());
        }

        public void ShowTInfo()
        {
            foreach (var item in Data)
            {
                if (item.Name.StartsWith("T"))
                {
                    Console.WriteLine(item.Name + "\t" + item.GetSalary());
                }
            }
        }

        public void Show3()
        {
            foreach (var item in Data)
            {
                if (item is FullTime)
                {
                    FullTime t = (FullTime)item;
                    if (t.Heso < 3)
                    {
                        String[] words = item.Name.Split(' ');
                        String lastName = "";
                        for (int i = 1; i < words.Length; i++)
                        {
                            lastName += words[i] + " ";
                        }
                        Console.WriteLine(words[0] + "\t" + lastName);
                    }
                }
            }
        }

        public double GetMaxSalary()
        {
            double maxSalary = 0;
            foreach (var item in Data)
            {
                if (maxSalary < item.GetSalary())
                {
                    maxSalary = item.GetSalary();
                }
            }
            return maxSalary;
        }

        void IManager.SaveFile()
        {
            try
            {
                string filename = "D:\\FPT\\Term 5 SU23\\PRN211\\Projects\\PRN211_SE1713\\OOP\\data.txt";
                //string filename = "data.txt";
                /* C1
                StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine("Hello");
                writer.Close();
                */

                //C2
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var teacher in Data)
                    {
                        writer.WriteLine(teacher + "\t" + (teacher is FullTime ? "0" : "1"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save fail: " + ex.Message);
            }
        }

        void IManager.LoadFile()
        {
            Data.Clear();
            try
            {
                string filename = "..\\..\\..\\data.txt";
                //string filename = "data.txt";

                //C2
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        string[] s = line.Split('\t');
                        if (s.Length == 4)
                        {
                            string code = s[0].Trim();
                            if (checkCode(Data, code))
                            {
                                line = reader.ReadLine();
                                continue;
                            }
                            string name = s[1].Trim();
                            double salary = Convert.ToDouble(s[2].Trim());
                            if (s[3].Trim().Equals("0"))
                            {
                                double heso = salary / 2000000;
                                Teacher t = new FullTime(code, name, heso);
                                Data.Add(t);
                            }
                            else
                            {
                                int slot = (int)salary / 100000;
                                Teacher t = new PartTime(code, name, slot);
                                Data.Add(t);
                            }
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load fail: " + ex.Message);
            }
        }

        private bool checkCode(List<Teacher> data, string code)
        {
            foreach (Teacher t in data)
            {
                if (t.Code == code)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
