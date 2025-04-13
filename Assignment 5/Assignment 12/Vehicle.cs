namespace Assignment12
{
    class Vehicle
    {
        // Properties with access modifiers
        public string Make { get; private set; }
        public int Year { get; set; }
        private double Price { get; set; }

        // Constructor to initialize the properties
        public Vehicle(string make, int year, double price)
        {
            Make = make;
            Year = year;
            Price = price;
        }

        // Public method to display vehicle details
        public void DisplayVehicleInfo()
        {
            Console.WriteLine($"Make: {Make}\nYear: {Year}\nPrice: ${Price}");
        }

        // Private method to manipulate the price (private access modifier)
        private void AdjustPrice(double amount)
        {
            Price += amount;
            Console.WriteLine($"Price adjusted by {amount}. New price: ${Price}");
        }

        // Public method to allow price adjustment (accessible from outside the class)
        public void IncreasePrice(double amount)
        {
            AdjustPrice(amount);  // Internal price adjustment logic
            Console.WriteLine("Price increased successfully.");
        }
    }
}
