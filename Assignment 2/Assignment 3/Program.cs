using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }
 
        void Start()
        {
            Console.WriteLine("Enter positive integers to check if they are perfect squares.");
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

                // Call the IsPerfectSquare method to check if the number is a perfect square
                bool isPerfectSquare = IsPerfectSquare(userInput);
                if (isPerfectSquare)
                {
                    Console.WriteLine($"{userInput} is a perfect square.");
                }
                else
                {
                    Console.WriteLine($"{userInput} is not a perfect square.");
                }
            }
        }

        // Method to check if a number is a perfect square
        bool IsPerfectSquare(int number)
        {
            // Find the square root of the number
            double sqrt = Math.Sqrt(number);
            
            // If the square root is an integer, return true; otherwise, return false
            return sqrt == (int)sqrt;
        }
    }
}
