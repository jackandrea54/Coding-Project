using LAB1;

internal class Program
{
    private static void Main(string[] args)
    {
        String filename = @"..\\..\\..\\employees.txt";
        EmployeeController employeeController = new EmployeeController();
        Console.WriteLine("============================Read from file=================");
        employeeController.ReadEmployeeFromFile(filename);
        Console.WriteLine("============================Read from file done=================");
        while (true)
        {
            int choice = employeeController.Menu();
            switch (choice)
            {
                case 1:
                    int id = InputReader.ReadInt("Enter id: ");
                    Employee employee = employeeController.FindEmployeeById(id);
                    if (employee == null)
                    {
                        Console.WriteLine("Employee not found");
                    }
                    else
                    {
                        Console.WriteLine(employee);
                    }
                    break;
                case 2:
                    String name = InputReader.ReadString("Enter name: ");
                    employeeController.FindEmployeesByName(name).Display();
                    break;
                case 3:
                    String position = InputReader.ReadString("Enter position: ");
                    employeeController.FindEmployeesByPosition(position).Display();
                    break;
                case 4:
                    int minSalary = InputReader.ReadInt("Enter min Salary: ");
                    int maxSalary = InputReader.ReadInt("Enter max Salary: ");
                    employeeController.FindEmployeesHasBaseSalary(minSalary, maxSalary).Display();
                    break;
                case 5:
                    int minYearlySalary = InputReader.ReadInt("Enter min Salary: ");
                    int maxYearlySalary = InputReader.ReadInt("Enter max Salary: ");
                    employeeController.FindEmployeesHasYearlySalary(minYearlySalary, maxYearlySalary).Display();
                    break;
                case 6:
                    employeeController.getAllEmployee().Display();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
   