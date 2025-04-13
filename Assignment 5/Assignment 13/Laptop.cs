namespace Assignment13
{
    class Laptop
    {
        // Auto-implemented properties
        public string Brand { get; set; }
        public int UsedStorage { get; set; }
        public int TotalStorage { get; set; }

        // Calculated property for free storage
        public int FreeStorage
        {
            get { return TotalStorage - UsedStorage; }
        }

        // Constructor to initialize properties
        public Laptop(string brand, int usedStorage, int totalStorage)
        {
            Brand = brand;
            UsedStorage = usedStorage;
            TotalStorage = totalStorage;
        }

        // Method to display laptop details
        public void DisplayLaptopInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nUsed Storage: {UsedStorage} GB\nTotal Storage: {TotalStorage} GB\nFree Storage: {FreeStorage} GB");
        }
    }
}
