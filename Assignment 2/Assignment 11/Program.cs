using System;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Call method to print FizzBuzz for numbers 1 to 20
            PrintFizzBuzz();
        }

        // Method to print FizzBuzz for numbers from 1 to 20
        void PrintFizzBuzz()
        {
            // Loop through numbers from 1 to 20
            for (int i = 1; i <= 20; i++)
            {
                // Check if the number is divisible by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check if the number is divisible by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check if the number is divisible by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    // If not divisible by 3 or 5, just print the number
                    Console.WriteLine(i);
                }
            }
        }
    }
}
