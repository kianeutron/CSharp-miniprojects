using System;

namespace Assignment43
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number to calculate its digital root: ");
            int number = int.Parse(Console.ReadLine());

            int digitalRoot = CalculateDigitalRoot(number);
            Console.WriteLine($"The digital root of {number} is: {digitalRoot}");
        }

        // Method to calculate the digital root of a number
        int CalculateDigitalRoot(int number)
        {
            // Keep calculating the sum of digits until we get a single digit
            while (number >= 10)
            {
                number = SumOfDigits(number);
            }
            return number;
        }

        // Helper method to calculate the sum of digits of a number
        int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;  // Get the last digit and add to sum
                number /= 10;         // Remove the last digit
            }
            return sum;
        }
    }
}
