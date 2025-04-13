using System;

namespace Assignment24
{
    class Program
    {
        // Start method to create an employee and display their info
        static void Start()
        {
            // Create an Employee object with test data
            Employee employee = new Employee("John Doe", 50000, 10);

            // Display employee details including their calculated bonus
            employee.DisplayEmployeeInfo();
        }

        // Main method to run the Start method
        static void Main(string[] args)
        {
            Start();
        }
    }
}
