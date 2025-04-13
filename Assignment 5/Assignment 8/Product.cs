namespace Assignment8
{
    internal class Product
    {
        public string ProductName { get; private set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice
        {
            get { return Price * Quantity; }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Price: {TotalPrice:C}");
        }
    }
}
