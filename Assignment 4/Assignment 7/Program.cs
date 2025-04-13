namespace Assignment7
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
            // A list to store cart items
            List<CartItem> cart = new List<CartItem>();

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Add Item to Cart\n2. Remove Item from Cart\n3. Display Cart\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            // Add item to cart
                            AddItemToCart(cart);
                            break;

                        case 2:
                            // Remove item from cart
                            RemoveItemFromCart(cart);
                            break;

                        case 3:
                            // Display cart contents
                            DisplayCart(cart);
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

        // Method to add an item to the cart
        public void AddItemToCart(List<CartItem> cart)
        {
            Console.Write("Enter the product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter the product price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            // Add the item to the cart
            cart.Add(new CartItem(productName, price, quantity));
            Console.WriteLine($"{productName} has been added to the cart.");
        }

        // Method to remove an item from the cart
        public void RemoveItemFromCart(List<CartItem> cart)
        {
            Console.Write("Enter the product name to remove: ");
            string productName = Console.ReadLine();

            // Find and remove the item by product name
            var itemToRemove = cart.Find(item => item.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine($"{productName} has been removed from the cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }

        // Method to display the cart contents and calculate the total price
        public void DisplayCart(List<CartItem> cart)
        {
            if (cart.Count > 0)
            {
                Console.WriteLine("\nCart Contents:");
                double total = 0;
                foreach (var item in cart)
                {
                    Console.WriteLine($"{item.ProductName}: {item.Quantity} x {item.Price} = {item.GetItemTotal()}");
                    total += item.GetItemTotal();
                }

                // Display the total price of the cart
                Console.WriteLine($"Total Cart Price: {total}");
            }
            else
            {
                Console.WriteLine("The cart is empty.");
            }
        }
    }
}
