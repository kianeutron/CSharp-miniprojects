using System;

namespace Assignment37
{
    class Program
    {
        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }

        // Start method to create and display the Employee details
        static void Start()
        {
            // Create an Employee object with Name and Salary
            Employee employee = new Employee("John Doe", 50000);

            // Display the employee details and bonus
            employee.DisplayEmployeeInfo();
        }
    }
}
