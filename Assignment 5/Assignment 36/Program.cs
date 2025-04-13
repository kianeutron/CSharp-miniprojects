using System;

namespace Assignment36
{
    class Program
    {
        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }

        // Start method to create and display the Invoice
        static void Start()
        {
            // Create an Invoice object with ItemName, Quantity, and UnitPrice
            Invoice invoice = new Invoice("Laptop", 5, 799.99);

            // Display the invoice details
            invoice.DisplayInvoiceInfo();
        }
    }
}
