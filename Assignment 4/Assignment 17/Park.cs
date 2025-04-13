namespace Assignment17
{
    public class Park
    {
        public string Name { get; set; }
        public double DailyEntryFee { get; set; }
        public int AvailableTickets { get; set; }

        // Constructor to initialize park details
        public Park(string name, double dailyEntryFee, int availableTickets)
        {
            Name = name;
            DailyEntryFee = dailyEntryFee;
            AvailableTickets = availableTickets;
        }

        // Method to book tickets and update available tickets
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
