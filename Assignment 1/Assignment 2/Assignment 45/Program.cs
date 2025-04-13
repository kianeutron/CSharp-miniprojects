using System;

namespace Assignment45
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPerfect = IsPerfectNumber(number);
            if (isPerfect)
                Console.WriteLine($"{number} is a perfect number.");
            else
                Console.WriteLine($"{number} is not a perfect number.");
        }

        // Method to check if the number is a perfect number
        bool IsPerfectNumber(int number)
        {
            int sumOfDivisors = 0;

            // Loop to find all divisors excluding the number itself
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) // Check if 'i' is a divisor
                {
                    sumOfDivisors += i;
                }
            }

            // If the sum of divisors equals the number, it's a perfect number
            return sumOfDivisors == number;
        }
    }
}
