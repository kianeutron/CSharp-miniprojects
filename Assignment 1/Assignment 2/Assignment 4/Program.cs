using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter positive integers to check if they are prime numbers.");
            Console.WriteLine("Enter 0 or a negative number to stop.");
            
            // Loop to repeatedly ask the user for input
            while (true)
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                // Stop the loop if the user enters 0 or a negative number
                if (userInput <= 0)
                {
                    break;
                }

                // Call the IsPrime method to check if the number is prime
                bool isPrime = IsPrime(userInput);
                if (isPrime)
                {
                    Console.WriteLine($"{userInput} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{userInput} is not a prime number.");
                }
            }
        }

        // Method to check if a number is prime
        bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;  // Numbers less than or equal to 1 are not prime
            }

            // Loop from 2 to the square root of the number to check for divisors
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)  // If divisible, it's not a prime number
                {
                    return false;
                }
            }

            // If no divisors were found, the number is prime
            return true;
        }
    }
}
