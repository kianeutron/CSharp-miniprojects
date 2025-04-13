namespace Assignment23
{
    public class Invoice
    {
        // Properties
        public string InvoiceNumber { get; }
        public double Amount { get; set; }
        public DateTime DateIssued { get; }

        // Constructor to initialize properties
        public Invoice(string invoiceNumber, double amount, DateTime dateIssued)
        {
            InvoiceNumber = invoiceNumber;
            Amount = amount;
            DateIssued = dateIssued;
        }

        // Calculated property for Tax (10% of Amount)
        public double Tax
        {
            get { return Amount * 0.10; }
        }

        // Method to display invoice details
        public void DisplayInvoiceInfo()
        {
            Console.WriteLine($"Invoice Number: {InvoiceNumber}\nAmount: ${Amount}\nDate Issued: {DateIssued.ToShortDateString()}\nTax: ${Tax:F2}");
        }
    }
}
