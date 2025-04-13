using System;

namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for two positive integers
            Console.Write("Enter the first positive number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second positive number: ");
            int number2 = int.Parse(Console.ReadLine());

            // Check if number2 is a multiple of number1 and display the result
            if (IsMultiple(number1, number2))
            {
                Console.WriteLine($"{number2} is a multiple of {number1}.");
            }
            else
            {
                Console.WriteLine($"{number2} is not a multiple of {number1}.");
            }
        }

        // Method to check if number2 is a multiple of number1
        bool IsMultiple(int number1, int number2)
        {
            // Use modulus operator to check if number2 is divisible by number1
            return number2 % number1 == 0;
        }
    }
}
