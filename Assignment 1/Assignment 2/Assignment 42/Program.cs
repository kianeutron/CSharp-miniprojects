using System;

namespace Assignment42
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

            if (AreAmicableNumbers(number1, number2))
            {
                Console.WriteLine($"{number1} and {number2} are amicable numbers.");
            }
            else
            {
                Console.WriteLine($"{number1} and {number2} are not amicable numbers.");
            }
        }

        // Method to check if two numbers are amicable
        bool AreAmicableNumbers(int number1, int number2)
        {
            int sum1 = SumOfDivisors(number1);
            int sum2 = SumOfDivisors(number2);

            return sum1 == number2 && sum2 == number1;
        }

        // Method to calculate the sum of proper divisors of a number
        int SumOfDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) // Divisor found
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
