namespace Assignment16
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
            // Step 1: Create movie and snack arrays
            Movie[] movies = {
                new Movie("Avengers: Endgame", 50, 12.00),
                new Movie("The Lion King", 40, 10.50),
                new Movie("Inception", 30, 15.00)
            };

            Snack[] snacks = {
                new Snack("Popcorn", 5.00, true),
                new Snack("Soda", 3.00, false),
                new Snack("Candy", 2.50, false),
                new Snack("Combo - Popcorn + Soda", 7.00, true)
            };

            double totalAmount = 0;

            // Step 2: Display available movies and snacks
            Console.WriteLine("Available Movies:");
            DisplayMovies(movies);

            // Ask user to choose movie and book tickets
            Console.WriteLine("Enter the movie number to book tickets:");
            int movieNumber = int.Parse(Console.ReadLine()) - 1;

            if (movieNumber >= 0 && movieNumber < movies.Length)
            {
                Console.WriteLine($"How many tickets for \"{movies[movieNumber].Title}\" would you like to book?");
                int ticketsToBook = int.Parse(Console.ReadLine());

                // Try booking tickets and calculate total cost
                if (movies[movieNumber].BookTickets(ticketsToBook))
                {
                    totalAmount += ticketsToBook * movies[movieNumber].TicketPrice;
                    Console.WriteLine($"{ticketsToBook} tickets booked for \"{movies[movieNumber].Title}\".");
                }
                else
                {
                    Console.WriteLine("Not enough tickets available.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid movie selection.");
                return;
            }

            // Step 3: Display available snacks and ask user to choose
            Console.WriteLine("\nAvailable Snacks:");
            DisplaySnacks(snacks);

            Console.WriteLine("Enter the snack number to add to your order (0 to skip):");
            int snackNumber = int.Parse(Console.ReadLine()) - 1;

            if (snackNumber >= 0 && snackNumber < snacks.Length)
            {
                Console.WriteLine($"How many of \"{snacks[snackNumber].Name}\" would you like to order?");
                int snackQuantity = int.Parse(Console.ReadLine());

                totalAmount += snackQuantity * snacks[snackNumber].Price;
                Console.WriteLine($"{snackQuantity} \"{snacks[snackNumber].Name}\" added to your order.");
            }

            // Step 4: Display the total cost
            Console.WriteLine($"\nTotal Cost: {totalAmount:C}");
        }

        // Method to display available movies
        public void DisplayMovies(Movie[] movies)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title} - Tickets Available: {movies[i].AvailableTickets} - Price: {movies[i].TicketPrice:C}");
            }
        }

        // Method to display available snacks
        public void DisplaySnacks(Snack[] snacks)
        {
            for (int i = 0; i < snacks.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {snacks[i].GetDetails()}");
            }
        }
    }
}
