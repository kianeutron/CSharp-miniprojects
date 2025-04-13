using System;

namespace Assignment44
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

            bool areTwinPrimes = AreTwinPrimes(number1, number2);
            if (areTwinPrimes)
                Console.WriteLine($"{number1} and {number2} are twin primes.");
            else
                Console.WriteLine($"{number1} and {number2} are not twin primes.");
        }

        // Method to check if two numbers are twin primes
        bool AreTwinPrimes(int number1, int number2)
        {
            // Check if the difference between the numbers is 2
            if (Math.Abs(number1 - number2) != 2)
                return false;

            // Check if both numbers are prime
            return IsPrime(number1) && IsPrime(number2);
        }

        // Method to check if a number is prime
        bool IsPrime(int number)
        {
            if (number < 2) return false; // Numbers less than 2 are not prime
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; // Found a divisor, number is not prime
            }
            return true;
        }
    }
}
