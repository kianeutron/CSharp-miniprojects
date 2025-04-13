namespace Assignment18
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
            // Step 1: Create concert and refreshment arrays
            Concert[] concerts = {
                new Concert("The Rockers", 150, 50.00),
                new Concert("Jazz Nights", 200, 40.00),
                new Concert("Pop Fest", 250, 30.00)
            };

            Refreshment[] refreshments = {
                new Refreshment("Beer", 5.00, true),
                new Refreshment("Soda", 2.00, false),
                new Refreshment("Water", 1.50, false),
                new Refreshment("Cocktail", 7.00, true)
            };

            double totalCost = 0;

            // Step 2: Display concerts and refreshments
            Console.WriteLine("Available Concerts:");
            DisplayConcerts(concerts);

            Console.WriteLine("Enter the concert number to book tickets:");
            int concertNumber = int.Parse(Console.ReadLine()) - 1;

            if (concertNumber >= 0 && concertNumber < concerts.Length)
            {
                Console.WriteLine($"How many tickets for \"{concerts[concertNumber].BandName}\" would you like to book?");
                int ticketsToBook = int.Parse(Console.ReadLine());

                // Try booking tickets and calculate total cost
                if (concerts[concertNumber].BookTickets(ticketsToBook))
                {
                    totalCost += ticketsToBook * concerts[concertNumber].TicketCost;
                    Console.WriteLine($"{ticketsToBook} tickets booked for \"{concerts[concertNumber].BandName}\".");
                }
                else
                {
                    Console.WriteLine("Not enough tickets available.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid concert selection.");
                return;
            }

            // Step 3: Display refreshment items and ask user to choose
            Console.WriteLine("\nAvailable Refreshments:");
            DisplayRefreshments(refreshments);

            Console.WriteLine("Enter the refreshment number to add to your order (0 to skip):");
            int refreshmentNumber = int.Parse(Console.ReadLine()) - 1;

            if (refreshmentNumber >= 0 && refreshmentNumber < refreshments.Length)
            {
                Console.WriteLine($"How many of \"{refreshments[refreshmentNumber].ItemName}\" would you like to order?");
                int refreshmentQuantity = int.Parse(Console.ReadLine());

                totalCost += refreshmentQuantity * refreshments[refreshmentNumber].Price;
                Console.WriteLine($"{refreshmentQuantity} \"{refreshments[refreshmentNumber].ItemName}\" added to your order.");
            }

            // Step 4: Display the total cost
            Console.WriteLine($"\nTotal Cost: {totalCost:C}");
        }

        // Method to display available concerts
        public void DisplayConcerts(Concert[] concerts)
        {
            for (int i = 0; i < concerts.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {concerts[i].BandName} - Ticket Price: {concerts[i].TicketCost:C} - Tickets Available: {concerts[i].AvailableTickets}");
            }
        }

        // Method to display available refreshments
        public void DisplayRefreshments(Refreshment[] refreshments)
        {
            for (int i = 0; i < refreshments.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {refreshments[i].GetDescription()}");
            }
        }
    }
}
