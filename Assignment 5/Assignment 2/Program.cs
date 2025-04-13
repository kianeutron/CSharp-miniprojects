using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Vehicle vehicle = ReadVehicle();
            vehicle.DisplayVehicleInfo();
        }

        static Vehicle ReadVehicle()
        {
            Console.Write("Enter the vehicle make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the mileage: ");
            int mileage;
            while (!int.TryParse(Console.ReadLine(), out mileage) || mileage < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer for mileage.");
            }

            return new Vehicle(make, mileage);
        }
    }
}
