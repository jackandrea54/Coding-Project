
using Lesson2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");
        Student stu1 = new Student();
        Student stu2= new Student(2,"Nga");
        Student stu3 = new Student();
        stu1.ID = 1;
        stu1.Name = "Nghia";

        stu3.Input();

        stu1.Display();
        stu2.Display();
        stu3.Display();

        SEStudent se = new SEStudent(4,"Hai dang", "C#");
        SEStudent se2 = new SEStudent();
        se2.Input();
        *//*se.ID = 4;
        se.Name = "hai Dnag";
        se.skill = "big C#";*//*
        se.Display();
        se2.Display();
        
        Student s = new SEStudent();
        s.Display();*/

        Student stu1 = new Student(1, "Nghia");
        Student stu2 = new Student(1, "Nghia");
        if (stu1.Equals(stu2))
        {
            Console.WriteLine("Damn they are equal");
        }
        else {
            Console.WriteLine("Damn they are not equal");
        }
    }
}