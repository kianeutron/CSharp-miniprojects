using System;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            int[] numbers = new int[5];  // Array to hold 5 user-entered integers

            // Ask the user to enter 5 positive integers
            Console.WriteLine("Enter 5 positive integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Call the method to calculate and display the odd/even sums
            CalculateOddEvenSums(numbers);
        }

        // Method to calculate the sum of odd and even numbers separately
        void CalculateOddEvenSums(int[] numbers)
        {
            int oddSum = 0;
            int evenSum = 0;

            // Loop through each number and check if it's odd or even
            foreach (int number in numbers)
            {
                if (number % 2 == 0)  // If the number is even
                {
                    evenSum += number;
                }
                else  // If the number is odd
                {
                    oddSum += number;
                }
            }

            // Display the sum of odd and even numbers
            Console.WriteLine($"The sum of odd numbers is: {oddSum}");
            Console.WriteLine($"The sum of even numbers is: {evenSum}");
        }
    }
}
