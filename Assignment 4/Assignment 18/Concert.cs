namespace Assignment18
{
    public class Concert
    {
        public string BandName { get; set; }
        public int AvailableTickets { get; set; }
        public double TicketCost { get; set; }

        // Constructor to initialize concert details
        public Concert(string bandName, int availableTickets, double ticketCost)
        {
            BandName = bandName;
            AvailableTickets = availableTickets;
            TicketCost = ticketCost;
        }

        // Method to book concert tickets and update availability
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
