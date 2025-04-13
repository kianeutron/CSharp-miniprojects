namespace Assignment5
{
    public class Smartphone
    {
        // Properties
        public string Brand { get; } // Read-only property
        private int usedStorage; // Backing field for UsedStorage

        public int UsedStorage // Read/write property with validation
        {
            get => usedStorage;
            set
            {
                if (value >= 0 && value <= TotalStorage) // Ensure storage is within valid range
                {
                    usedStorage = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Used storage must be between 0 and the total storage capacity.");
                }
            }
        }

        public int TotalStorage { get; } // Read-only property

        // Calculated Property
        public int FreeStorage => TotalStorage - UsedStorage;

        // Constructor
        public Smartphone(string brand, int totalStorage, int usedStorage)
        {
            Brand = brand;
            TotalStorage = totalStorage;
            UsedStorage = usedStorage; // This will use the setter for validation
        }

        // Method to Display Phone Details
        public void DisplayPhoneDetails()
        {
            Console.WriteLine("\n--- Smartphone Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Total Storage: {TotalStorage} GB");
            Console.WriteLine($"Used Storage: {UsedStorage} GB");
            Console.WriteLine($"Free Storage: {FreeStorage} GB");
        }
    }
}
