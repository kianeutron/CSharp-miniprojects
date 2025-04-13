namespace Assignment19
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create and initialize match array and concession array (with some example data)
            Match[] matches = new Match[]
            {
                new Match("Team A vs Team B", 100, 20),
                new Match("Team C vs Team D", 50, 25)
            };

            Concession[] concessions = new Concession[]
            {
                new Concession("Hot Dog", 5, false),
                new Concession("Soft Drink", 3, false),
                new Concession("Combo (Snack + Drink)", 7, true)
            };

            // Step 2: Display available matches and concessions
            DisplayMatches(matches);
            DisplayConcessions(concessions);

            // Step 3: Ask the user how many tickets they want to book
            Console.WriteLine("\nEnter the number of seats you want to book:");
            int seatsRequested;
            if (int.TryParse(Console.ReadLine(), out seatsRequested) && seatsRequested > 0)
            {
                int matchIndex = GetMatchIndex(matches);
                BookSeats(matches, matchIndex, seatsRequested);
            }
            else
            {
                Console.WriteLine("Invalid number of seats.");
            }

            // Step 4: Ask the user how many concessions they want to order
            Console.WriteLine("\nEnter the number of concession items you want to purchase:");
            int concessionQuantity;
            if (int.TryParse(Console.ReadLine(), out concessionQuantity) && concessionQuantity > 0)
            {
                int concessionIndex = GetConcessionIndex(concessions);
                BookConcessions(concessions, concessionIndex, concessionQuantity);
            }
            else
            {
                Console.WriteLine("Invalid concession quantity.");
            }
        }

        int GetMatchIndex(Match[] matches)
        {
            Console.WriteLine("\nWhich match would you like to book tickets for?");
            for (int i = 0; i < matches.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {matches[i].TeamNames}");
            }

            int matchIndex;
            if (int.TryParse(Console.ReadLine(), out matchIndex) && matchIndex > 0 && matchIndex <= matches.Length)
            {
                return matchIndex - 1;
            }

            Console.WriteLine("Invalid selection.");
            return -1;
        }

        int GetConcessionIndex(Concession[] concessions)
        {
            Console.WriteLine("\nWhich concession item would you like to purchase?");
            for (int i = 0; i < concessions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {concessions[i].Item}");
            }

            int concessionIndex;
            if (int.TryParse(Console.ReadLine(), out concessionIndex) && concessionIndex > 0 && concessionIndex <= concessions.Length)
            {
                return concessionIndex - 1;
            }

            Console.WriteLine("Invalid selection.");
            return -1;
        }

        void DisplayMatches(Match[] matches)
        {
            Console.WriteLine("\nAvailable Matches:");
            foreach (var match in matches)
            {
                Console.WriteLine(match.GetDetails());
            }
        }

        void DisplayConcessions(Concession[] concessions)
        {
            Console.WriteLine("\nAvailable Concessions:");
            foreach (var concession in concessions)
            {
                Console.WriteLine(concession.GetDetails());
            }
        }

        void BookSeats(Match[] matches, int matchIndex, int seatsRequested)
        {
            if (matchIndex >= 0 && matchIndex < matches.Length)
            {
                var match = matches[matchIndex];
                if (seatsRequested <= match.AvailableSeats)
                {
                    match.BookSeats(seatsRequested);
                    Console.WriteLine($"You have successfully booked {seatsRequested} seats for {match.TeamNames}. Total cost: {seatsRequested * match.TicketPrice}");
                }
                else
                {
                    Console.WriteLine("Not enough available seats.");
                }
            }
        }

        void BookConcessions(Concession[] concessions, int concessionIndex, int quantity)
        {
            if (concessionIndex >= 0 && concessionIndex < concessions.Length)
            {
                var concession = concessions[concessionIndex];
                Console.WriteLine($"You have successfully ordered {quantity} x {concession.Item}. Total cost: {quantity * concession.Price}");
            }
        }
    }
}
