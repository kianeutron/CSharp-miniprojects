using System;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Create an array to hold 5 numbers
            int[] numbers = new int[5];

            // Ask the user to input 5 numbers
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Calculate and display the average of the numbers
            double average = GetArrayAverage(numbers);
            Console.WriteLine($"The average of the numbers is: {average}");
        }

        // Method to calculate the average of the numbers in the array
        double GetArrayAverage(int[] numbers)
        {
            double sum = 0;

            // Loop through the array to calculate the sum of the numbers
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Calculate the average by dividing the sum by the number of elements in the array
            return sum / numbers.Length;
        }
    }
}
