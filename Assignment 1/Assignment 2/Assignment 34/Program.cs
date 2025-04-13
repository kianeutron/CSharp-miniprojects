using System;

namespace Assignment34
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number to check if it's an abundant number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsAbundant(number))
            {
                Console.WriteLine($"{number} is an abundant number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an abundant number.");
            }
        }

        // Method to check if the number is abundant
        bool IsAbundant(int number)
        {
            int sumOfDivisors = 0;

            // Loop through numbers from 1 to (number - 1) to find the divisors
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)  // If i is a divisor of number
                {
                    sumOfDivisors += i;  // Add it to the sum of divisors
                }
            }

            // Compare the sum of divisors with the original number
            return sumOfDivisors > number;
        }
    }
}
