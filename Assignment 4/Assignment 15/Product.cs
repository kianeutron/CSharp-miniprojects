namespace Assignment15
{
    using System;

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Constructor to initialize product details
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Method to get product details
        public string GetDetails()
        {
            return $"{Name} - Price: {Price:C} - Stock: {Stock}";
        }
    }
}
