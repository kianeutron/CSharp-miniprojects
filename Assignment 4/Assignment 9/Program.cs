namespace Assignment9
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        public void Start()
        {
            // Create an array to store vehicles
            Vehicle[] vehicles = new Vehicle[]
            {
                new Vehicle("Car"),
                new Vehicle("Van"),
                new Vehicle("Truck"),
                new Vehicle("Motorcycle"),
                new Vehicle("Bicycle")
            };

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Rent Vehicle\n2. Return Vehicle\n3. Display All Vehicles\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            // Rent a vehicle
                            RentVehicle(vehicles);
                            break;

                        case 2:
                            // Return a rented vehicle
                            ReturnVehicle(vehicles);
                            break;

                        case 3:
                            // Display all vehicles' statuses
                            DisplayAllVehicles(vehicles);
                            break;

                        case 4:
                            // Exit the program
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Method to rent a vehicle
        public void RentVehicle(Vehicle[] vehicles)
        {
            Console.Write("Enter the vehicle type (Car/Van/Truck/Motorcycle/Bicycle) to rent: ");
            string vehicleType = Console.ReadLine();

            bool found = false;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.VehicleType.Equals(vehicleType, StringComparison.OrdinalIgnoreCase))
                {
                    vehicle.RentVehicle();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No vehicle found with type {vehicleType}.");
            }
        }

        // Method to return a rented vehicle
        public void ReturnVehicle(Vehicle[] vehicles)
        {
            Console.Write("Enter the vehicle type (Car/Van/Truck/Motorcycle/Bicycle) to return: ");
            string vehicleType = Console.ReadLine();

            bool found = false;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.VehicleType.Equals(vehicleType, StringComparison.OrdinalIgnoreCase))
                {
                    vehicle.ReturnVehicle();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No vehicle found with type {vehicleType}.");
            }
        }

        // Method to display all vehicles' statuses
        public void DisplayAllVehicles(Vehicle[] vehicles)
        {
            Console.WriteLine("\nVehicle Statuses:");
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayStatus();
            }
        }
    }
}
