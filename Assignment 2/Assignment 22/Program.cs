using System;

namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for a range of numbers
            Console.Write("Enter the starting number of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number of the range: ");
            int end = int.Parse(Console.ReadLine());

            // Display prime numbers in the specified range
            DisplayPrimesInRange(start, end);
        }

        // Method to display all primes in the given range
        void DisplayPrimesInRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Method to check if a number is prime
        bool IsPrime(int number)
        {
            if (number <= 1) return false; // numbers less than 2 are not prime
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; // if divisible by any number other than 1 and itself, it's not prime
            }
            return true;
        }
    }
}
