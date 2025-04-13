using System;

namespace Assignment35
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number to check if it's a deficient number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsDeficient(number))
            {
                Console.WriteLine($"{number} is a deficient number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a deficient number.");
            }
        }

        // Method to check if the number is deficient
        bool IsDeficient(int number)
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
            return sumOfDivisors < number;
        }
    }
}
