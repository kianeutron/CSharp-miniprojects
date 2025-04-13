internal class Movie
  {
      public string Title;
      public int AvailableTickets;
      public Movie(string title, int availableTickets)
      {
          Title = title;
          AvailableTickets = availableTickets;    
      }
      public void BookTickets(int numberOfTickets)
      {
          
          AvailableTickets = AvailableTickets-numberOfTickets;
      }
  }