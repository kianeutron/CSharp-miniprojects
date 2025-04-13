using System;

namespace Assignment29
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());
            
            // Calculate and display the sum of squares in the range
            int sum = SumOfSquares(start, end);
            Console.WriteLine($"The sum of squares in the range from {start} to {end} is: {sum}");
        }

        // Method to calculate the sum of squares in a given range (inclusive)
        int SumOfSquares(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i * i; // Add the square of the current number to the sum
            }
            return sum;
        }
    }
}
