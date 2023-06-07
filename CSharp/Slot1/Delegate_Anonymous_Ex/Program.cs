// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using Delegate_Anonymous_Ex;
using Excerse_01;
internal class Program
{
    private static void Main(string[] args)
    {
        /* DemoDelegate();*/
        //DelegateMultiCast();
        DemoUsingComparision();
    }

    public static int Add(int x, int y)
    {
        Console.WriteLine("Add function: ");
        return x + y;
    }

    public static int Sub(int x, int y)
    {
        Console.WriteLine("Sub function: ");
        return x - y;
    }

    //Neu chi biet co 1 ham co 2 tham so int
    //Thuc hien phep tinh nao thi chua biet
    public static int Caculate(int x, int y, Calculation delobj)
    {
        return delobj(x, y); //Noi quyet dinh goi ham
    }


    public static void DemoDelegate()
    {
        Calculation delegateobj; //Khai bao 1 bien delegate

        delegateobj = new Calculation(Add); //Khoi tao delegate, them loi goi ham Add
        Console.WriteLine("Output: " + delegateobj(150, 100));

        delegateobj = Sub; //Thay the ham Add bang ham Sub
        /*delegateobj = new Calculation(Sub); */
        Console.WriteLine("Output: " + delegateobj(9, 6));


        Console.WriteLine("Output: " + Caculate(20, 25, Add));
    }

    //Mot tinh chat khac cua delegate
    public static void DelegateMultiCast()
    {
        Calculation delegateobj = Add; //Them ham Add vao loi goi ham
        delegateobj += Sub; //Them ham Sub
        delegateobj += Add;
        Console.WriteLine("Output: " + delegateobj(9, 6));

        delegateobj -= Add;
        delegateobj -= Add;
        Console.WriteLine("Output: " + delegateobj(100, 50));

        delegateobj -= Sub;
        //Console.WriteLine("Output: " + delegateobj(100, 50)); // Loi Runtime vi delegate khong tro vao ham nao

    }

    public static void DemoUsingComparision()
    {
        CourseList courseList = new CourseList();
        courseList.InitData();
        Console.WriteLine("Sort by Id: ");
        courseList.SortById();
        courseList.DisplayListOfCourse();
        
        Console.WriteLine("Sort by Title: ");
        courseList.SortByTitle();
        courseList.DisplayListOfCourse();

        Console.WriteLine("Sort by Start Date: ");
        courseList.SortByStartDate();
        courseList.DisplayListOfCourse();

    }


}