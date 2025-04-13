using System;

namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for two numbers
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Calculate and display the GCD of the two numbers
            int gcd = CalculateGCD(num1, num2);
            Console.WriteLine($"The greatest common divisor (GCD) of {num1} and {num2} is: {gcd}");
        }

        // Method to calculate GCD using the Euclidean algorithm
        int CalculateGCD(int num1, int num2)
        {
            // Make sure both numbers are positive
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            // Use Euclidean algorithm to find GCD
            while (num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            return num1;
        }
    }
}
