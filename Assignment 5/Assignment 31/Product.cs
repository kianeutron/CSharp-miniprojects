using System;

namespace Assignment31
{
    class Product
    {
        // Properties for Name and Price with private setter for Price
        public string Name { get; private set; }
        public double Price { get; private set; }

        // Constructor to initialize Name and Price
        public Product(string name, double price)
        {
            Name = name;
            // You can apply validations here if necessary (e.g., ensure price is positive)
            if (price >= 0)
            {
                Price = price;
            }
            else
            {
                throw new ArgumentException("Price cannot be negative.");
            }
        }

        // Method to display product details
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Price: {Price:C}");
        }
    }
}
