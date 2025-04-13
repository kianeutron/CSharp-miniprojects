namespace Assignment3
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Start method is called from here
            new Program().Start();
        }

        // Start method now handles the main program interaction
        public void Start()
        {
            // Create a list of products
            Product product1 = new Product("Laptop", 50);
            Product product2 = new Product("Phone", 100);
            Product product3 = new Product("Headphones", 30);

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Add Stock\n2. Deduct Stock\n3. Display Inventory\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    // Handle user inputs
                    switch (choice)
                    {
                        case 1:
                            // Add stock
                            Console.Write("Enter product name to add stock (Laptop, Phone, Headphones): ");
                            string productToAddStock = Console.ReadLine();
                            Console.Write("Enter amount of stock to add: ");
                            int amountToAdd = int.Parse(Console.ReadLine());

                            AddStockToProduct(productToAddStock, amountToAdd, product1, product2, product3);
                            break;

                        case 2:
                            // Deduct stock
                            Console.Write("Enter product name to deduct stock (Laptop, Phone, Headphones): ");
                            string productToDeductStock = Console.ReadLine();
                            Console.Write("Enter amount of stock to deduct: ");
                            int amountToDeduct = int.Parse(Console.ReadLine());

                            DeductStockFromProduct(productToDeductStock, amountToDeduct, product1, product2, product3);
                            break;

                        case 3:
                            // Display inventory
                            product1.DisplayDetails();
                            product2.DisplayDetails();
                            product3.DisplayDetails();
                            break;

                        case 4:
                            // Exit
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Method to add stock to the correct product
        public void AddStockToProduct(string productName, int amount, Product product1, Product product2, Product product3)
        {
            if (productName.Equals("Laptop", StringComparison.OrdinalIgnoreCase))
            {
                product1.AddStock(amount);
            }
            else if (productName.Equals("Phone", StringComparison.OrdinalIgnoreCase))
            {
                product2.AddStock(amount);
            }
            else if (productName.Equals("Headphones", StringComparison.OrdinalIgnoreCase))
            {
                product3.AddStock(amount);
            }
            else
            {
                Console.WriteLine("Invalid product name.");
            }
        }

        // Method to deduct stock from the correct product
        public void DeductStockFromProduct(string productName, int amount, Product product1, Product product2, Product product3)
        {
            if (productName.Equals("Laptop", StringComparison.OrdinalIgnoreCase))
            {
                product1.DeductStock(amount);
            }
            else if (productName.Equals("Phone", StringComparison.OrdinalIgnoreCase))
            {
                product2.DeductStock(amount);
            }
            else if (productName.Equals("Headphones", StringComparison.OrdinalIgnoreCase))
            {
                product3.DeductStock(amount);
            }
            else
            {
                Console.WriteLine("Invalid product name.");
            }
        }
    }
}
