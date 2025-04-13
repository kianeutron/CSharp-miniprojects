using System;

namespace Assignment31
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            if (exponent < 0)
            {
                Console.WriteLine("Exponent cannot be negative.");
            }
            else
            {
                int result = CalculatePower(baseNumber, exponent);
                Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
            }
        }

        // Method to calculate power using recursion
        int CalculatePower(int baseNumber, int exponent)
        {
            if (exponent == 0)  // Base case: any number raised to the power of 0 is 1
                return 1;
            else
                return baseNumber * CalculatePower(baseNumber, exponent - 1);  // Recursive case
        }
    }
}
