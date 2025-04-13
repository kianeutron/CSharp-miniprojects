using System;

namespace Assignment23
{
    class Program
    {
        // Start method to create and display an Invoice object
        static void Start()
        {
            // Create an Invoice object with example data
            Invoice invoice = new Invoice("INV12345", 500.00, DateTime.Now);

            // Display the invoice details, including tax
            invoice.DisplayInvoiceInfo();
        }

        // Main method to run the Start method
        static void Main(string[] args)
        {
            Start();
        }
    }
}
