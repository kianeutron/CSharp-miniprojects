namespace Assignment3
{
    public class Laptop
    {
        // Properties
        public string Model { get; } // Read-only property
        private int batteryPercentage; // Backing field for BatteryPercentage

        public int BatteryPercentage // Read/write property with validation
        {
            get => batteryPercentage;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    batteryPercentage = value;
                }
            }
        }

        // Calculated Property
        public bool NeedsCharging => BatteryPercentage < 20;

        // Constructor
        public Laptop(string model, int batteryPercentage)
        {
            Model = model;
            BatteryPercentage = batteryPercentage >= 0 && batteryPercentage <= 100 ? batteryPercentage : 0;
        }

        // Method to display laptop details
        public void DisplayLaptopInfo()
    {}
    }
}
        