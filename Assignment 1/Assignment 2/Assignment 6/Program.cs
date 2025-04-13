
namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter positive integers to count their factors.");
            Console.WriteLine("Enter 0 or a negative number to stop.");

            // Loop to repeatedly ask the user for input
            while (true)
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                // Stop the loop if the user enters 0 or a negative number
                if (userInput <= 0)
                {
                    break;
                }

                // Call the CountFactors method to calculate how many factors the number has
                int factorCount = CountFactors(userInput);
                Console.WriteLine($"The number {userInput} has {factorCount} factors.");
            }
        }

        // Method to count how many factors the number has
        int CountFactors(int number)
        {
            int count = 0;

            // Loop through numbers from 1 to the given number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)  // If i divides number evenly
                {
                    count++;
                }
            }

            return count;
        }
    }
}
