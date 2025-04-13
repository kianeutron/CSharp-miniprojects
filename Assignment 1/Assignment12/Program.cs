namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Time Duration Calculator");
            Console.WriteLine("1: Convert Minutes to Hours");
            Console.WriteLine("2: Convert Seconds to Minutes");

            // Get user input for conversion choice
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            // Ask for the value based on the conversion choice
            if (choice == 1)
            {
                Console.Write("Enter time in minutes: ");
                double minutes = double.Parse(Console.ReadLine());
                double hours = ConvertMinutesToHours(minutes);
                Console.WriteLine($"{minutes} minutes = {hours} hours");
            }
            else if (choice == 2)
            {
                Console.Write("Enter time in seconds: ");
                double seconds = double.Parse(Console.ReadLine());
                double minutes = ConvertSecondsToMinutes(seconds);
                Console.WriteLine($"{seconds} seconds = {minutes} minutes");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
            }
        }

        // Method to convert minutes to hours
        double ConvertMinutesToHours(double minutes)
        {
            return minutes / 60;
        }

        // Method to convert seconds to minutes
        double ConvertSecondsToMinutes(double seconds)
        {
            return seconds / 60;
        }
    }
}
