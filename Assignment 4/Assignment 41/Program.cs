
internal class Program
  {
      static void Main(string[] args)
      {
          Program program = new Program();
          program.Start();
      }
      void Start()
      {
          Movie[] movies=new Movie[3];
          movies[0] = new Movie("Joker",120);
          movies[1] = new Movie("Beetlejuice",80);
          movies[2] = new Movie("The Substance",100);
          DisplayMovies(movies);
          Console.Write("\nSelect a movie number to book tickets: ");
          int movieNum= int.Parse(Console.ReadLine());
          Console.Write($"How many tickets would you like to book for {movies[movieNum-1].Title}?");
          int numTickets=int.Parse(Console.ReadLine());
          movies[movieNum-1].BookTickets(numTickets);
          Console.WriteLine($"You have successfully booked {numTickets} ticket(s) for {movies[movieNum - 1].Title}.\n");
          DisplayMovies(movies);
      }
      void DisplayMovies(Movie[] movies) 
      {
          Console.WriteLine("Available Movies:");
          for (int i = 0; i < movies.Length; i++) {
              Console.WriteLine($"{i+1}. Title {movies[i].Title}, Available Tickets: {movies[i].AvailableTickets}");
          }
      }
  }