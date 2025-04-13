namespace Assignment19
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Prompt user for input
            Console.WriteLine("Enter a number between 1 and 7:");
            int dayNumber;

            // Validate user input
            if (int.TryParse(Console.ReadLine(), out dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                // Call GetDayOfWeek method
                string dayOfWeek = GetDayOfWeek(dayNumber);

                // Display the corresponding day
                Console.WriteLine($"The day of the week is: {dayOfWeek}");
            }
            else
            {
                // Invalid input message
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }

        string GetDayOfWeek(int dayNumber)
        {
            // Return the day of the week based on the number
            switch (dayNumber)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Invalid"; // Should never reach here due to validation in Start()
            }
        }
    }
}
