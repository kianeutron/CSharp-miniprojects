namespace Assignment6
{
    public class Appliance
    {
        // Properties
        public string Type { get; } // Read-only property for appliance type
        private int hoursUsed; // Backing field for HoursUsed

        public int HoursUsed // Read/write property with validation
        {
            get => hoursUsed;
            set
            {
                if (value >= 0) // Ensure hoursUsed is non-negative
                {
                    hoursUsed = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Hours used must be non-negative.");
                }
            }
        }

        // Calculated Property
        public bool NeedsReplacement => HoursUsed > 20000; // Returns true if hoursUsed exceeds 20,000

        // Constructor
        public Appliance(string type, int hoursUsed)
        {
            Type = type;
            HoursUsed = hoursUsed; // This will use the setter for validation
        }

        // Method to Display Appliance Details
        public void DisplayApplianceDetails()
        {
            Console.WriteLine("\n--- Appliance Details ---");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Hours Used: {HoursUsed} hours");
            Console.WriteLine($"Needs Replacement: {NeedsReplacement}");
        }
    }
}
