using System;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Product product = ReadProduct();
            product.DisplayProductInfo();
        }

        static Product ReadProduct()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            return new Product(productName, price, quantity);
        }
    }
}
