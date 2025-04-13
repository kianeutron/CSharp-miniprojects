namespace Assignment17
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
            // Step 1: Create park and food stall arrays
            Park[] parks = {
                new Park("Adventure Park", 50.00, 100),
                new Park("Fantasy World", 60.00, 80),
                new Park("Safari Land", 40.00, 120)
            };

            FoodStall[] stalls = {
                new FoodStall("Burger", 8.00, false),
                new FoodStall("Vegan Wrap", 7.50, true),
                new FoodStall("Hot Dog", 5.00, false),
                new FoodStall("Smoothie", 6.00, true)
            };

            double totalCost = 0;

            // Step 2: Display parks and food stalls
            Console.WriteLine("Available Parks:");
            DisplayParks(parks);

            Console.WriteLine("Enter the park number to book tickets:");
            int parkNumber = int.Parse(Console.ReadLine()) - 1;

            if (parkNumber >= 0 && parkNumber < parks.Length)
            {
                Console.WriteLine($"How many tickets for \"{parks[parkNumber].Name}\" would you like to book?");
                int ticketsToBook = int.Parse(Console.ReadLine());

                // Try booking tickets and calculate total cost
                if (parks[parkNumber].BookTickets(ticketsToBook))
                {
                    totalCost += ticketsToBook * parks[parkNumber].DailyEntryFee;
                    Console.WriteLine($"{ticketsToBook} tickets booked for \"{parks[parkNumber].Name}\".");
                }
                else
                {
                    Console.WriteLine("Not enough tickets available.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid park selection.");
                return;
            }

            // Step 3: Display food stalls and ask user to choose
            Console.WriteLine("\nAvailable Food Stalls:");
            DisplayStalls(stalls);

            Console.WriteLine("Enter the food stall number to add to your order (0 to skip):");
            int foodStallNumber = int.Parse(Console.ReadLine()) - 1;

            if (foodStallNumber >= 0 && foodStallNumber < stalls.Length)
            {
                Console.WriteLine($"How many of \"{stalls[foodStallNumber].ItemName}\" would you like to order?");
                int foodQuantity = int.Parse(Console.ReadLine());

                totalCost += foodQuantity * stalls[foodStallNumber].ItemPrice;
                Console.WriteLine($"{foodQuantity} \"{stalls[foodStallNumber].ItemName}\" added to your order.");
            }

            // Step 4: Display the total cost
            Console.WriteLine($"\nTotal Cost: {totalCost:C}");
        }

        // Method to display available parks
        public void DisplayParks(Park[] parks)
        {
            for (int i = 0; i < parks.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {parks[i].Name} - Entry Fee: {parks[i].DailyEntryFee:C} - Tickets Available: {parks[i].AvailableTickets}");
            }
        }

        // Method to display available food stalls
        public void DisplayStalls(FoodStall[] stalls)
        {
            for (int i = 0; i < stalls.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {stalls[i].GetDetails()}");
            }
        }
    }
}
