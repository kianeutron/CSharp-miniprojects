using System;

namespace Assignment18
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for the start and end of the range
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            // Calculate sums of odd and even numbers in the range
            int sumOdd = CalculateSumOfOddNumbers(start, end);
            int sumEven = CalculateSumOfEvenNumbers(start, end);

            // Display the results
            Console.WriteLine($"Sum of odd numbers in the range: {sumOdd}");
            Console.WriteLine($"Sum of even numbers in the range: {sumEven}");
        }

        // Method to calculate the sum of odd numbers in the given range
        int CalculateSumOfOddNumbers(int start, int end)
        {
            int sumOdd = 0;

            // Loop through the range and add odd numbers to the sum
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0) // Check if the number is odd
                {
                    sumOdd += i;
                }
            }

            return sumOdd;
        }

        // Method to calculate the sum of even numbers in the given range
        int CalculateSumOfEvenNumbers(int start, int end)
        {
            int sumEven = 0;

            // Loop through the range and add even numbers to the sum
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0) // Check if the number is even
                {
                    sumEven += i;
                }
            }

            return sumEven;
        }
    }
}
