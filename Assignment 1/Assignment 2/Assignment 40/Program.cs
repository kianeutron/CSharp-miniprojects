using System;

namespace Assignment40
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

            Console.WriteLine("Narcissistic numbers between " + start + " and " + end + " are:");
            for (int i = start; i <= end; i++)
            {
                if (IsNarcissistic(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Method to check if a number is narcissistic
        bool IsNarcissistic(int number)
        {
            int originalNumber = number;
            int digitCount = number.ToString().Length;
            int sumOfPowers = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfPowers += (int)Math.Pow(digit, digitCount);
                number /= 10;
            }

            return sumOfPowers == originalNumber;
        }
    }
}
