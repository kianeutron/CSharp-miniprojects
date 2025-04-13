namespace Assignment16
{
    public class Movie
    {
        public string Title { get; set; }
        public int AvailableTickets { get; set; }
        public double TicketPrice { get; set; }

        // Constructor to initialize movie details
        public Movie(string title, int availableTickets, double ticketPrice)
        {
            Title = title;
            AvailableTickets = availableTickets;
            TicketPrice = ticketPrice;
        }

        // Method to book tickets and update availability
        public bool BookTickets(int numberOfTickets)
        {
            if (AvailableTickets >= numberOfTickets)
            {
                AvailableTickets -= numberOfTickets;
                return true;
            }
            return false;
        }
    }
}
