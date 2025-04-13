namespace Assignment3
{
    using System;

    public class Product
    {
        // Fields
        public string Name { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        // Method to add stock
        public void AddStock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
                Console.WriteLine($"{amount} items of {Name} have been added to the stock.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }

        // Method to deduct stock
        public void DeductStock(int amount)
        {
            if (amount > 0 && amount <= Stock)
            {
                Stock -= amount;
                Console.WriteLine($"{amount} items of {Name} have been deducted from the stock.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Ensure that stock is available and the amount is positive.");
            }
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name} | Stock: {Stock}");
        }
    }
}
