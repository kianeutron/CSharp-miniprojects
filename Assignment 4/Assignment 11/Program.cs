namespace Assignment11
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        public void Start()
        {
            // Step 1: Create an array of products
            Product[] products = {
                new Product("Laptop", 1200.50, 10),
                new Product("Smartphone", 799.99, 20),
                new Product("Headphones", 199.99, 50),
                new Product("Monitor", 250.75, 15)
            };

            bool continueOrdering = true;
            double totalCost = 0;

            while (continueOrdering)
            {
                // Step 2: Display products
                Console.WriteLine("Available Products:");
                DisplayProducts(products);

                // Step 3: Ask user to choose a product
                Console.WriteLine("Enter the product number to order (or 0 to exit):");
                int productNumber = int.Parse(Console.ReadLine()) - 1;

                if (productNumber == -1)
                {
                    // Exit ordering
                    continueOrdering = false;
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (productNumber >= 0 && productNumber < products.Length)
                {
                    // Step 4: Ask for quantity to order
                    Console.WriteLine("Enter the quantity to order:");
                    int quantity = int.Parse(Console.ReadLine());

                    // Step 5: Process the order
                    if (products[productNumber].OrderProduct(quantity))
                    {
                        double cost = quantity * products[productNumber].Price;
                        totalCost += cost;
                        Console.WriteLine($"Order placed for {quantity} {products[productNumber].Name}(s). Total cost for this item: {cost:C}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product selection.");
                }

                // Step 6: Ask if the user wants to continue ordering
                Console.WriteLine("Do you want to order more products? (y/n):");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice != 'y' && choice != 'Y')
                {
                    continueOrdering = false;
                    Console.WriteLine("Exiting...");
                }
            }

            // Step 7: Display the total order cost
            Console.WriteLine($"\nTotal Cost of your order: {totalCost:C}");
        }

        // Method to display all products
        public void DisplayProducts(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].GetDetails()}");
            }
        }
    }
}
