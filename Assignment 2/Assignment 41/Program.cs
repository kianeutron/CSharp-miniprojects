using System;

namespace Assignment41
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

            if (IsPerfectSquare(number))
            {
                Console.WriteLine($"{number} is a perfect square.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect square.");
            }
        }

        // Method to check if a number is a perfect square
        bool IsPerfectSquare(int number)
        {
            if (number < 0) return false;

            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
