using System;

namespace Assignment37
{
    public class Employee
    {
        // Private fields for Name and Salary
        private string _name;
        private double _salary;

        // Constructor: Initializes Name and Salary
        public Employee(string name, double salary)
        {
            _name = name;
            _salary = salary;
        }

        // Public Property: Name
        public string Name
        {
            get { return _name; }
        }

        // Public Property: Salary
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        // Calculated Property: Bonus
        public double Bonus
        {
            get { return _salary * 0.1; } // 10% bonus based on salary
        }

        // Method to display the employee's details and bonus
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Bonus: {Bonus:C}");
        }
    }
}
