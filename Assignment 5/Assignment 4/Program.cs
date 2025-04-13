namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Employee employee = ReadEmployee(); // Get employee details
            employee.DisplayEmployeeDetails(); // Display details
        }

        static Employee ReadEmployee()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            int weeklyHours;
            do
            {
                Console.Write("Enter weekly hours worked: ");
            }
            while (!int.TryParse(Console.ReadLine(), out weeklyHours) || weeklyHours < 0);

            return new Employee(name, weeklyHours); // Return new Employee object
        }
    }
}
