namespace Assignment38
{
    public class EmployeeManager
    {
        private Employee[] employees;
        private int currentIndex;

        // Constructor to initialize the array of employees
        public EmployeeManager(int capacity)
        {
            employees = new Employee[capacity];
            currentIndex = 0;
        }

        // Method to add an employee to the array
        public void AddEmployee(Employee employee)
        {
            if (currentIndex < employees.Length)
            {
                employees[currentIndex] = employee;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Employee list is full. Cannot add more employees.");
            }
        }

        // Method to calculate the average salary of all employees
        public void CalculateAverageSalary()
        {
            double totalSalary = 0;
            int employeeCount = currentIndex;

            if (employeeCount == 0)
            {
                Console.WriteLine("No employees to calculate average salary.");
                return;
            }

            for (int i = 0; i < employeeCount; i++)
            {
                totalSalary += employees[i].Salary;
            }

            double averageSalary = totalSalary / employeeCount;
            Console.WriteLine($"The average salary of all employees is: {averageSalary:C}");
        }

        // Method to display all employees and their details
        public void DisplayEmployees()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            Console.WriteLine("Employee Details:");
            for (int i = 0; i < currentIndex; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }
    }
}
