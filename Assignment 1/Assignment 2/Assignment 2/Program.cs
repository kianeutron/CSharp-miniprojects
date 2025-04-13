using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter positive integers to calculate the sum of digits.");
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

                // Call the CalculateDigitSum method to get the sum of digits
                int sum = CalculateDigitSum(userInput);
                Console.WriteLine($"The sum of the digits of {userInput} is: {sum}");
            }
        }

        // Method to calculate the sum of digits of a number
        int CalculateDigitSum(int number)
        {
            int sum = 0;

            // Loop to extract digits and accumulate their sum
            while (number > 0)
            {
                sum += number % 10;  // Get the last digit
                number /= 10;         // Remove the last digit
            }

            return sum;
        }
    }
}
