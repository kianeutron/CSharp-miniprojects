using System;

namespace Assignment30
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start method to execute the program logic
            new Program().Start();
        }

        public void Start()
        {
            // Create an array to hold the 3 integers
            int[] numbers = new int[3];

            // Prompt the user to enter 3 integers
            Console.WriteLine("Please enter 3 integers:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                // Read and store each integer entered by the user
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Calculate and display the sum of the integers
            int sum = CalculateSum(numbers);
            Console.WriteLine($"The sum of the integers is: {sum}");

            // Calculate and display the average of the integers
            double average = CalculateAverage(numbers);
            Console.WriteLine($"The average of the integers is: {average}");
        }

        // Method to calculate the sum of the array elements
        public int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Method to calculate the average of the array elements
        public double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length;
        }
    }
}
