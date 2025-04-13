using System;

namespace Assignment12
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
            // Method to create and display vehicle
            Vehicle vehicle = ReadVehicle();
            vehicle.DisplayVehicleInfo();

            // Manipulate price using public method
            Console.WriteLine("Increasing vehicle price by $5000.");
            vehicle.IncreasePrice(5000);
            vehicle.DisplayVehicleInfo(); // Show updated details
        }

        // Method to create and return a Vehicle object based on user input
        static Vehicle ReadVehicle()
        {
            Console.Write("Enter the make of the vehicle: ");
            string make = Console.ReadLine();

            Console.Write("Enter the year of the vehicle: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of the vehicle: ");
            double price = double.Parse(Console.ReadLine());

            return new Vehicle(make, year, price);
        }
    }
}
