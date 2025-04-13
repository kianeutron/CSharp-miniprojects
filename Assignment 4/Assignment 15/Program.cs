namespace Assignment15
{
    using System;
    using System.Collections.Generic;

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
                new Product("Laptop", 800.00, 10),
                new Product("Smartphone", 500.00, 5),
                new Product("Headphones", 100.00, 20),
                new Product("Tablet", 300.00, 15)
            };

            // Cart to hold selected products
            List<Product> cart = new List<Product>();

            double totalAmount = 0;
            bool continueShopping = true;

            while (continueShopping)
            {
                // Step 2: Display available products
                Console.WriteLine("Available Products:");
                DisplayProducts(products);

                // Step 3: Ask user to select a product
                Console.WriteLine("Enter the product number to add to your cart (or 0 to checkout):");
                int productNumber = int.Parse(Console.ReadLine()) - 1;

                if (productNumber == -1)
                {
                    // Checkout and exit shopping
                    continueShopping = false;
                    Console.WriteLine("Proceeding to checkout...");
                    break;
                }

                if (productNumber >= 0 && productNumber < products.Length)
                {
                    // Step 4: Ask how many units of the selected product the user wants
                    Console.WriteLine($"Enter the quantity of {products[productNumber].Name} you want to add to the cart:");
                    int quantity = int.Parse(Console.ReadLine());

                    // Check stock availability
                    if (quantity > 0 && quantity <= products[productNumber].Stock)
                    {
                        // Add product to cart and update stock
                        products[productNumber].Stock -= quantity;
                        for (int i = 0; i < quantity; i++)
                        {
                            cart.Add(products[productNumber]);
                        }

                        totalAmount += products[productNumber].Price * quantity;

                        Console.WriteLine($"You added {quantity} x {products[productNumber].Name} to your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient stock or invalid quantity.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product selection.");
                }

                // Step 5: Ask if the user wants to continue shopping
                Console.WriteLine("Do you want to add more products to your cart? (y/n):");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice != 'y' && choice != 'Y')
                {
                    continueShopping = false;
                    Console.WriteLine("Proceeding to checkout...");
                }
            }

            // Step 6: Display the total amount
            Console.WriteLine("\nYour Cart:");
            foreach (var item in cart)
            {
                Console.WriteLine(item.GetDetails());
            }

            Console.WriteLine($"\nTotal Amount: {totalAmount:C}");
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
