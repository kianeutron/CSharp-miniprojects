using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Create an array to store the numbers entered by the user
            int[] numbers = new int[100]; // assuming a max of 100 inputs to simplify
            int count = 0;

            Console.WriteLine("Enter positive integers to check if they are even.");
            Console.WriteLine("Enter 0 or a negative number to stop.");

            // Loop to repeatedly ask the user for input
            while (true)
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                // Break the loop if the user enters 0 or a negative number
                if (userInput <= 0)
                {
                    break;
                }

                // Store the number in the array
                numbers[count] = userInput;
                count++;
            }

            // Call the CountEvenNumbers method to get the count of even numbers
            int evenCount = CountEvenNumbers(numbers);
            Console.WriteLine($"Total even numbers entered: {evenCount}");
        }

        // Method to count the number of even numbers in the array
        int CountEvenNumbers(int[] numbers)
        {
            int evenCount = 0;

            // Loop through the array and count the even numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    break;  // If zero is reached, stop processing further
                }
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            return evenCount;
        }
    }
}
