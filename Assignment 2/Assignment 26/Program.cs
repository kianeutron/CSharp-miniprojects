using System;

namespace Assignment26
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
            // Get digit counts
            int[] digitCounts = CountDigits(number);

            // Display counts for each digit (0-9)
            Console.WriteLine("Digit counts:");
            for (int i = 0; i < digitCounts.Length; i++)
            {
                Console.WriteLine($"Digit {i}: {digitCounts[i]}");
            }
        }

        // Method to count each digit (0-9) in the number
        int[] CountDigits(int number)
        {
            int[] counts = new int[10];  // Array to hold the count of each digit (0-9)
            while (number > 0) 
            {
                int digit = number % 10;  // Get the last digit of the number
                counts[digit]++;          // Increment the count for this digit
                number /= 10;             // Remove the last digit
            }
            return counts;
        }
    }
}
