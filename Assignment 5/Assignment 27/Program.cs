using System;

namespace Assignment27
{
    class Program
    {
        // Start method to create a Car object and display its information
        static void Start()
        {
            // Create a Car object with sample data
            Car car = new Car("Toyota", "Corolla", 2020);

            // Display the details of the car
            car.DisplayCarInfo();

            // Modify Year using property setter
            car.Year = 2022;

            // Display updated car details
            Console.WriteLine("\nUpdated Car Information:");
            car.DisplayCarInfo();
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
