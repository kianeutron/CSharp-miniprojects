
namespace Assignment26
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

            // Ask the user to enter the divisor
            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());

            // Call the DisplayDivisibility method to check and display result
            DisplayDivisibility(number, divisor);
        }

        // Method to check if the number is divisible by the divisor
        bool IsDivisible(int number, int divisor)
        {
            return number % divisor == 0; // Returns true if divisible
        }

        // Method to display if the number is divisible by the divisor or not
        void DisplayDivisibility(int number, int divisor)
        {
            if (IsDivisible(number, divisor))
            {
                Console.WriteLine($"The number {number} is divisible by {divisor}.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not divisible by {divisor}.");
            }
        }
    }
}
