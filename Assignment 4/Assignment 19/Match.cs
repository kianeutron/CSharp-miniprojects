namespace Assignment19
{
    class Match
    {
        public string TeamNames { get; }
        public int AvailableSeats { get; private set; }
        public int TicketPrice { get; }

        public Match(string teamNames, int availableSeats, int ticketPrice)
        {
            TeamNames = teamNames;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
        }

        public void BookSeats(int seatsRequested)
        {
            if (seatsRequested <= AvailableSeats)
            {
                AvailableSeats -= seatsRequested;
            }
        }

        public string GetDetails()
        {
            return $"{TeamNames} - ${TicketPrice} per seat, {AvailableSeats} seats available.";
        }
    }
}
