namespace Assignment14
{
    using System;

    public class Event
    {
        public string Name { get; set; }
        public double TicketPrice { get; set; }
        public int AvailableSeats { get; set; }

        // Constructor to initialize event details
        public Event(string name, double ticketPrice, int availableSeats)
        {
            Name = name;
            TicketPrice = ticketPrice;
            AvailableSeats = availableSeats;
        }

        // Method to get event's details
        public string GetDetails()
        {
            return $"{Name} - Ticket Price: {TicketPrice:C} - Available Seats: {AvailableSeats}";
        }
    }
}
