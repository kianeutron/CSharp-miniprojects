namespace Assignment9
{
    using System;

    public class Vehicle
    {
        public string VehicleType { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor to initialize vehicle with its type and availability status
        public Vehicle(string vehicleType)
        {
            VehicleType = vehicleType;
            IsAvailable = true; // Initially, all vehicles are available
        }

        // Method to rent a vehicle
        public void RentVehicle()
        {
            if (IsAvailable)
            {
                IsAvailable = false; // Mark the vehicle as rented
                Console.WriteLine($"{VehicleType} has been successfully rented.");
            }
            else
            {
                Console.WriteLine($"{VehicleType} is currently unavailable for rent.");
            }
        }

        // Method to return a rented vehicle
        public void ReturnVehicle()
        {
            if (!IsAvailable)
            {
                IsAvailable = true; // Mark the vehicle as returned
                Console.WriteLine($"{VehicleType} has been successfully returned.");
            }
            else
            {
                Console.WriteLine($"{VehicleType} was not rented.");
            }
        }

        // Method to display the vehicle's status
        public void DisplayStatus()
        {
            Console.WriteLine($"{VehicleType}: {(IsAvailable ? "Available" : "Rented")}");
        }
    }
}
