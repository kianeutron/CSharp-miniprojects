using System;

namespace Assignment31
{
    class Program
    {
        // Start method to create and display product
        static void Start()
        {
            // Create a Product object
            Product myProduct = new Product("Laptop", 999.99);

            // Display product info
            myProduct.DisplayProductInfo();

            // Trying to modify Price will result in a compilation error, 
            // because Price has a private setter and cannot be changed outside the class.
            // myProduct.Price = 1200; // Uncommenting this line will cause a compiler error.
        }

        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }
    }
}
