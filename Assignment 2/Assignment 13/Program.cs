using System;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to input a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is prime and display the result
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        // Method to check if a number is prime
        bool IsPrime(int number)
        {
            // Edge case: Numbers less than 2 are not prime
            if (number < 2)
                return false;

            // Check for divisibility from 2 to number / 2
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    // If a divisor is found, the number is not prime
                    return false;
                }
            }

            // If no divisors are found, the number is prime
            return true;
        }
    }
}
