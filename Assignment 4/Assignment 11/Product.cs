namespace Assignment11
{
    using System;

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Constructor to initialize Product details
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Method to get the product details
        public string GetDetails()
        {
            return $"{Name} - Price: {Price:C} - Stock: {Stock} available";
        }

        // Method to reduce stock when a product is ordered
        public bool OrderProduct(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine("Not enough stock available.");
                return false;
            }
        }
    }
}
