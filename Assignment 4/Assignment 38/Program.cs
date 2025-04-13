using System;

namespace Assignment38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an EmployeeManager with a capacity for 5 employees
            EmployeeManager employeeManager = new EmployeeManager(5);

            // Add employees to the system
            employeeManager.AddEmployee(new Employee("John Doe", 1, 50000));
            employeeManager.AddEmployee(new Employee("Jane Smith", 2, 60000));
            employeeManager.AddEmployee(new Employee("Michael Johnson", 3, 55000));
            employeeManager.AddEmployee(new Employee("Emily Davis", 4, 70000));
            employeeManager.AddEmployee(new Employee("David Brown", 5, 65000));

            // Display all employees and their details
            employeeManager.DisplayEmployees();

            // Calculate and display the average salary
            employeeManager.CalculateAverageSalary();
        }
    }
}
