using System;

namespace Assignment36
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter two temperature readings
            Console.WriteLine("Enter the first temperature:");
            double temp1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second temperature:");
            double temp2 = double.Parse(Console.ReadLine());

            // Call the DisplayTemperatureComparison method to compare the temperatures
            DisplayTemperatureComparison(temp1, temp2);
        }

        // Method to compare two temperatures and return the result as a string
        string CompareTemperatures(double temp1, double temp2)
        {
            if (temp1 > temp2)
            {
                return "The first temperature is warmer.";
            }
            else if (temp1 < temp2)
            {
                return "The second temperature is warmer.";
            }
            else
            {
                return "Both temperatures are equal.";
            }
        }

        // Method to display the result of comparing the temperatures
        void DisplayTemperatureComparison(double temp1, double temp2)
        {
            string comparisonResult = CompareTemperatures(temp1, temp2);
            Console.WriteLine(comparisonResult);
        }
    }
}
