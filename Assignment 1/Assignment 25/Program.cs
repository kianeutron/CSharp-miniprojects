
namespace Assignment25
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Call the DisplayRangeCheck method to validate and display result
            DisplayRangeCheck(number);
        }

        // Method to check if the number is within a specified range
        bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max; // Returns true if the number is within the range
        }

        // Method to display if the number is within the range or not
        void DisplayRangeCheck(int number)
        {
            int min = 1;
            int max = 100;

            // Check if the number is within the range using IsWithinRange
            if (IsWithinRange(number, min, max))
            {
                Console.WriteLine($"The number {number} is within the range {min}-{max}.");
            }
            else
            {
                Console.WriteLine($"The number {number} is out of the range {min}-{max}.");
            }
        }
    }
}
