using System;

namespace Assignment7;

internal class Employee
{
    public string Name { get; private set; }
    public double BasicSalary { get; set; }
    public double Bonus { get; set; }

    public Employee(string name, double basicSalary, double bonus)
    {
        Name = name;
        BasicSalary = basicSalary;
        Bonus = bonus;
    }

    public double TotalSalary
    {
        get { return BasicSalary + Bonus; }
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Basic Salary: {BasicSalary:C}");
        Console.WriteLine($"Bonus: {Bonus:C}");
        Console.WriteLine($"Total Salary: {TotalSalary:C}");
    }
}

