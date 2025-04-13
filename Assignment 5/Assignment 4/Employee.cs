namespace Assignment4
{
    public class Employee
    {
        // Properties
        public string Name { get; } // Read-only property
        private int weeklyHoursWorked; // Backing field for WeeklyHoursWorked

        public int WeeklyHoursWorked // Read/write property with validation
        {
            get => weeklyHoursWorked;
            set
            {
                if (value >= 0) // Validate non-negative hours
                {
                    weeklyHoursWorked = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Hours cannot be negative. Setting default to 0.");
                    weeklyHoursWorked = 0;
                }
            }
        }

        // Calculated Property
        public bool EligibleForOvertime => WeeklyHoursWorked > 40;

        // Constructor
        public Employee(string name, int weeklyHoursWorked)
        {
            Name = name;
            WeeklyHoursWorked = weeklyHoursWorked; // This will use the setter for validation
        }

        // Method to Display Employee Details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Weekly Hours Worked: {WeeklyHoursWorked}");
            Console.WriteLine(EligibleForOvertime ? "Eligible for overtime." : "Not eligible for overtime.");
        }
    }
}
