namespace Assignment2
{
    public class Vehicle
    {
        public string Make { get; } // Read-only property
        private int mileage;       // Backing field for Mileage
        public int Mileage         // Read/write property with validation
        {
            get => mileage;
            set
            {
                if (value >= 0)
                {
                    mileage = value;
                }
            }
        }

        // Calculated property
        public bool NeedsService => Mileage > 50000;

        // Constructor
        public Vehicle(string make, int mileage)
        {
            Make = make;
            Mileage = mileage >= 0 ? mileage : 0;
        }

        // Method to display vehicle details
        public void DisplayVehicleInfo()
        {
            Console.WriteLine($"Vehicle Make: {Make}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Needs Service: {NeedsService}");
        }
    }
}
