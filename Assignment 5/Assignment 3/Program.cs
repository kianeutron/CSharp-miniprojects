using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Laptop laptop = ReadLaptop();
            laptop.DisplayLaptopInfo();
        }

        static Laptop ReadLaptop()
        {
            Console.Write("Enter the laptop model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the battery percentage (0-100): ");
            int batteryPercentage;
            while (!int.TryParse(Console.ReadLine(), out batteryPercentage) || batteryPercentage < 0 || batteryPercentage > 100)
            {
                Console.WriteLine("Invalid input. Please enter a value between 0 and 100.");
            }

            return new Laptop(model, batteryPercentage);
        }
    }
}
