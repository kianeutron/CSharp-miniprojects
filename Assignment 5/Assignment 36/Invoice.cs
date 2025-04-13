using System;

namespace Assignment36
{
    public class Invoice
    {
        // Private fields for properties
        private string _itemName;
        private int _quantity;
        private double _unitPrice;

        // Constructor: Initializes ItemName, Quantity, and UnitPrice
        public Invoice(string itemName, int quantity, double unitPrice)
        {
            _itemName = itemName;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }

        // Public Property: ItemName
        public string ItemName
        {
            get { return _itemName; }
        }

        // Public Property: Quantity
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // Public Property: UnitPrice
        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        // Calculated Property: TotalAmount
        public double TotalAmount
        {
            get { return _quantity * _unitPrice; }
        }

        // Method to display the invoice details
        public void DisplayInvoiceInfo()
        {
            Console.WriteLine($"Item: {ItemName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Unit Price: {UnitPrice:C}");
            Console.WriteLine($"Total Amount: {TotalAmount:C}");
        }
    }
}
