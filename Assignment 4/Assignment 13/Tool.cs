namespace Assignment13
{
    using System;

    public class Tool
    {
        public string Name { get; set; }
        public double RatePerDay { get; set; }
        public int AvailableStock { get; set; }

        // Constructor to initialize tool details
        public Tool(string name, double ratePerDay, int availableStock)
        {
            Name = name;
            RatePerDay = ratePerDay;
            AvailableStock = availableStock;
        }

        // Method to get the tool's details
        public string GetDetails()
        {
            return $"{Name} - Rate per day: {RatePerDay:C} - Available Stock: {AvailableStock}";
        }
    }
}
