using System;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Employee employee = ReadEmployee();
            employee.DisplayEmployeeInfo();
        }

        static Employee ReadEmployee()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter basic salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            return new Employee(name, basicSalary, bonus);
        }
    }
}
