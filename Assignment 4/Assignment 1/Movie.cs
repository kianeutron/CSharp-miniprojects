using System;

namespace Assignment_1
{
    public class Movie
    {
        public string Title { get; set; }
        public int AvailableTickets { get; set; }

        public Movie(string title, int availableTickets)
        {
            Title = title;
            AvailableTickets = availableTickets;
        }

        public void BookTickets(int numberOfTickets)
        {
            if (numberOfTickets <= AvailableTickets)
            {
                AvailableTickets -= numberOfTickets;
                Console.WriteLine($"Successfully booked {numberOfTickets} tickets for {Title}. Tickets left: {AvailableTickets}");
            }
            else
            {
                Console.WriteLine("Not enough tickets available.");
            }
        }
    }
}
