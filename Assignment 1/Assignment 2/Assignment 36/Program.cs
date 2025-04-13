using System;

namespace Assignment36
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (AreFriendlyPairs(number1, number2))
            {
                Console.WriteLine($"{number1} and {number2} are friendly pairs.");
            }
            else
            {
                Console.WriteLine($"{number1} and {number2} are not friendly pairs.");
            }
        }

        // Method to check if two numbers are friendly pairs
        bool AreFriendlyPairs(int number1, int number2)
        {
            // Sum of divisors of number1
            int sum1 = SumOfDivisors(number1);

            // Sum of divisors of number2
            int sum2 = SumOfDivisors(number2);

            // Check if the numbers are friendly pairs
            return sum1 == number2 && sum2 == number1;
        }

        // Method to calculate the sum of proper divisors of a number
        int SumOfDivisors(int number)
        {
            int sum = 0;

            // Loop through numbers from 1 to number/2 to find the divisors
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)  // If i is a divisor of the number
                {
                    sum += i;  // Add it to the sum of divisors
                }
            }

            return sum;
        }
    }
}
