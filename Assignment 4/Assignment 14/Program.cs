namespace Assignment14
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
            // Step 1: Create an array of events
            Event[] events = {
                new Event("Concert", 50.00, 100),
                new Event("Theater Play", 30.00, 50),
                new Event("Stand-up Comedy", 20.00, 80),
                new Event("Football Match", 60.00, 200)
            };

            double totalCost = 0;
            bool continueBooking = true;

            while (continueBooking)
            {
                // Step 2: Display available events
                Console.WriteLine("Available Events:");
                DisplayEvents(events);

                // Step 3: Ask user to book tickets for an event
                Console.WriteLine("Enter the event number to book tickets (or 0 to exit):");
                int eventNumber = int.Parse(Console.ReadLine()) - 1;

                if (eventNumber == -1)
                {
                    // Exit booking
                    continueBooking = false;
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (eventNumber >= 0 && eventNumber < events.Length)
                {
                    // Ask how many tickets the user wants to book
                    Console.WriteLine($"Enter the number of tickets to book for '{events[eventNumber].Name}':");
                    int tickets = int.Parse(Console.ReadLine());

                    if (tickets > 0 && events[eventNumber].AvailableSeats >= tickets)
                    {
                        // Step 4: Calculate cost and update available seats
                        double bookingCost = events[eventNumber].TicketPrice * tickets;
                        totalCost += bookingCost;
                        events[eventNumber].AvailableSeats -= tickets;

                        Console.WriteLine($"You booked {tickets} tickets for '{events[eventNumber].Name}'. Total cost: {bookingCost:C}.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough available seats for '{events[eventNumber].Name}' or invalid number of tickets.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid event selection.");
                }

                // Step 5: Ask if the user wants to book more tickets
                Console.WriteLine("Do you want to book tickets for more events? (y/n):");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice != 'y' && choice != 'Y')
                {
                    continueBooking = false;
                    Console.WriteLine("Exiting...");
                }
            }

            // Step 6: Display the total booking cost
            Console.WriteLine($"\nTotal Booking Cost: {totalCost:C}");
        }

        // Method to display all events
        public void DisplayEvents(Event[] events)
        {
            for (int i = 0; i < events.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {events[i].GetDetails()}");
            }
        }
    }
}
