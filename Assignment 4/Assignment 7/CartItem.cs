namespace Assignment7
{
    using System;

    public class CartItem
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Constructor to initialize the CartItem with product name, price, and quantity
        public CartItem(string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        // Method to calculate the total price for this item (price * quantity)
        public double GetItemTotal()
        {
            return Price * Quantity;
        }
    }
}
