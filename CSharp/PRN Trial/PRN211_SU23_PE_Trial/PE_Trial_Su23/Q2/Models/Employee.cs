using System;
using System.Collections.Generic;

namespace Q2.Models;

public partial class Employee
{
    public Employee(string name, string sex, DateTime dob, string position)
    {
        Name = name;
        Sex = sex;
        Dob = dob;
        Position = position;
    }

    public Employee(int id, string name, string sex, DateTime dob, string position)
    {
        Id = id;
        Name = name;
        Sex = sex;
        Dob = dob;
        Position = position;
    }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Sex { get; set; }

    public DateTime Dob { get; set; }

    public string? Position { get; set; }

    public int? Department { get; set; }

    public virtual Department? DepartmentNavigation { get; set; }
}
