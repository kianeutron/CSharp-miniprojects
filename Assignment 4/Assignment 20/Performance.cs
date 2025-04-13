namespace Assignment20
{
    class Performance
    {
        public string Title { get; }
        public int AvailableSeats { get; private set; }
        public int PricePerTicket { get; }

        public Performance(string title, int availableSeats, int pricePerTicket)
        {
            Title = title;
            AvailableSeats = availableSeats;
            PricePerTicket = pricePerTicket;
        }

        public void ReserveSeats(int seatsRequested)
        {
            if (seatsRequested <= AvailableSeats)
            {
                AvailableSeats -= seatsRequested;
            }
        }

        public string GetDetails()
        {
            return $"{Title} - ${PricePerTicket} per ticket, {AvailableSeats} seats available.";
        }
    }
}
