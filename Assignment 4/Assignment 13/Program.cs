namespace Assignment13
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
            // Step 1: Create an array of tools
            Tool[] tools = {
                new Tool("Hammer", 5.00, 10),
                new Tool("Drill", 10.00, 5),
                new Tool("Wrench", 3.50, 8),
                new Tool("Screwdriver", 2.00, 20)
            };

            double totalCost = 0;
            bool continueRenting = true;

            while (continueRenting)
            {
                // Step 2: Display available tools
                Console.WriteLine("Available Tools:");
                DisplayTools(tools);

                // Step 3: Ask user to rent a tool
                Console.WriteLine("Enter the tool number to rent (or 0 to exit):");
                int toolNumber = int.Parse(Console.ReadLine()) - 1;

                if (toolNumber == -1)
                {
                    // Exit renting
                    continueRenting = false;
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (toolNumber >= 0 && toolNumber < tools.Length)
                {
                    // Ask how many days the user wants to rent
                    Console.WriteLine($"Enter the number of days to rent {tools[toolNumber].Name}:");
                    int days = int.Parse(Console.ReadLine());

                    if (days > 0 && tools[toolNumber].AvailableStock > 0)
                    {
                        // Step 4: Calculate cost and adjust stock
                        double rentalCost = tools[toolNumber].RatePerDay * days;
                        totalCost += rentalCost;
                        tools[toolNumber].AvailableStock--;

                        Console.WriteLine($"You rented {tools[toolNumber].Name} for {days} day(s). Total cost: {rentalCost:C}.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient stock or invalid number of days.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid tool selection.");
                }

                // Step 5: Ask if the user wants to rent more tools
                Console.WriteLine("Do you want to rent more tools? (y/n):");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice != 'y' && choice != 'Y')
                {
                    continueRenting = false;
                    Console.WriteLine("Exiting...");
                }
            }

            // Step 6: Display the total rental cost
            Console.WriteLine($"\nTotal Rental Cost: {totalCost:C}");
        }

        // Method to display all tools
        public void DisplayTools(Tool[] tools)
        {
            for (int i = 0; i < tools.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tools[i].GetDetails()}");
            }
        }
    }
}
