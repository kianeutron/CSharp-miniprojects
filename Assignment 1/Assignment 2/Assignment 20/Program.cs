using System;

namespace Assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for a range and the divisor
            Console.Write("Enter the starting number of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            // Display numbers in the range divisible by the divisor
            DisplayDivisibleNumbers(start, end, divisor);
        }

        // Method to display numbers divisible by the given divisor in the range
        void DisplayDivisibleNumbers(int start, int end, int divisor)
        {
            bool found = false;

            // Loop through the range and check divisibility
            Console.WriteLine($"Numbers divisible by {divisor} between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }

            // If no numbers are divisible by the divisor, display a message
            if (!found)
            {
                Console.WriteLine($"No numbers in this range are divisible by {divisor}.");
            }
            else
            {
                Console.WriteLine(); // New line after output
            }
        }
    }
}
