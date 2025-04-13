using System;

namespace Assignment30
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                int result = Factorial(number);
                Console.WriteLine($"The factorial of {number} is: {result}");
            }
        }

        // Method to calculate factorial using recursion
        int Factorial(int number)
        {
            if (number == 0 || number == 1)  // Base case: factorial of 0 or 1 is 1
                return 1;
            else
                return number * Factorial(number - 1);  // Recursive case
        }
    }
}
