using System;

namespace Assignment28
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
            
            Console.Write("Enter the number of multiples to generate: ");
            int count = int.Parse(Console.ReadLine());
            
            // Display the multiples
            DisplayMultiples(baseNumber, count);
        }

        // Method to display the multiples of the base number
        void DisplayMultiples(int baseNumber, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int multiple = baseNumber * i;
                Console.WriteLine($"{baseNumber} x {i} = {multiple}");
            }
        }
    }
}
