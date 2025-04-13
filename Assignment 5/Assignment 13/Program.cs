using System;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        // Start method to execute the main program flow
        static void Start()
        {
            // Method to create and display laptop
            Laptop laptop = ReadLaptop();
            laptop.DisplayLaptopInfo();
        }

        // Method to create and return a Laptop object based on user input
        static Laptop ReadLaptop()
        {
            Console.Write("Enter the brand of the laptop: ");
            string brand = Console.ReadLine();

            Console.Write("Enter the used storage in GB: ");
            int usedStorage = int.Parse(Console.ReadLine());

            Console.Write("Enter the total storage in GB: ");
            int totalStorage = int.Parse(Console.ReadLine());

            return new Laptop(brand, usedStorage, totalStorage);
        }
    }
}
