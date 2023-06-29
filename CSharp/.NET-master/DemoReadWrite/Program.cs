using System;
using System.IO;

namespace DemoReadWrite
{
    internal class Program
    {
        static void DemoDirectory()
        {
            //using class Directory
            Directory.CreateDirectory(@"D:\Semester 5\PRN211\test");

            //using class DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(@"D:\Semester 5\PRN211\test");
            dir.Create();
        }
        static void DemoDriveInfo()
        {
            //get all drive in computer
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
                Console.WriteLine($"{drive.Name} - {drive.DriveFormat} - {drive.DriveType} - {drive.TotalSize}");
            DriveInfo drive1 = new DriveInfo(@"C:\");
            Console.WriteLine(drive1.TotalSize);

        }
        static void DemoDirectoryInfoClass()
        {
            string theDir = @"D:\Semester 5\PRN211";
            DirectoryInfo mydir = new DirectoryInfo(theDir);
            FileInfo[] files = mydir.GetFiles("*.*", SearchOption.TopDirectoryOnly);
            //mydir.GetFiles();
            //Directory.GetFiles("D:\\Submit");

            DirectoryInfo[] dirs = mydir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            Console.WriteLine("Sub Directories:");
            foreach (DirectoryInfo dir in dirs)
            {
                Console.WriteLine("{0} - {1} - {2}", dir.Name, dir.CreationTime, dir.LastWriteTime);
            }

            Console.WriteLine("Files:");

            foreach (FileInfo file in files)
            {
                Console.WriteLine("{0} - {1} - {2}", file.Name, file.Length, file.LastWriteTime);

            }
            Console.ReadLine();
        }
        static void DemoUsingStream()
        {
            try
            {
                Stream inputStream = File.OpenRead(@"D:\PRN292\Demo\Demo_SystemIO\Demo_SystemIO\input.txt");
                Stream outputStream = File.OpenWrite(@"D:\PRN292\Demo\Demo_SystemIO\Demo_SystemIO\output.txt");
                int size = 1024;

                byte[] buffer = new byte[size];
                int bytesRead;
                while ((bytesRead = inputStream.Read(buffer, 0, size)) > 0)
                {
                    outputStream.Write(buffer, 0, size);

                }


                inputStream.Close();
                outputStream.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found - Message:" + e.Message);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }

        }

        static void DemoUsingStreamReaderWriter()
        {
            try
            {
                StreamReader reader = new StreamReader(@"D:\PRN292\Demo\Demo_SystemIO\Demo_SystemIO\input.txt");
                StreamWriter writer = new StreamWriter(@"D:\PRN292\Demo\Demo_SystemIO\Demo_SystemIO\output.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

                writer.Close();
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found - Message:" + e.Message);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
          DemoDirectoryInfoClass();



        }
    }
}
