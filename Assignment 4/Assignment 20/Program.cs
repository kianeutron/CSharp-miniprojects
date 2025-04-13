namespace Assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create and initialize performance array and merchandise array
            Performance[] performances = new Performance[]
            {
                new Performance("Shakespeare's Hamlet", 50, 30),
                new Performance("The Lion King", 100, 50)
            };

            Merchandise[] merchandise = new Merchandise[]
            {
                new Merchandise("T-Shirt", 20, "M", 50),
                new Merchandise("Mug", 10, "One Size", 30),
                new Merchandise("Cap", 15, "One Size", 40)
            };

            // Step 2: Display available performances and merchandise
            DisplayPerformances(performances);
            DisplayMerchandise(merchandise);

            // Step 3: Ask user to reserve seats for a performance
            Console.WriteLine("\nEnter the number of seats you want to reserve:");
            int seatsRequested;
            if (int.TryParse(Console.ReadLine(), out seatsRequested) && seatsRequested > 0)
            {
                int performanceIndex = GetPerformanceIndex(performances);
                ReserveSeats(performances, performanceIndex, seatsRequested);
            }
            else
            {
                Console.WriteLine("Invalid number of seats.");
            }

            // Step 4: Ask user to choose merchandise items and quantities
            Console.WriteLine("\nEnter the number of merchandise items you want to buy:");
            int merchandiseQuantity;
            if (int.TryParse(Console.ReadLine(), out merchandiseQuantity) && merchandiseQuantity > 0)
            {
                int merchandiseIndex = GetMerchandiseIndex(merchandise);
                BuyMerchandise(merchandise, merchandiseIndex, merchandiseQuantity);
            }
            else
            {
                Console.WriteLine("Invalid merchandise quantity.");
            }
        }

        // Select performance
        int GetPerformanceIndex(Performance[] performances)
        {
            Console.WriteLine("\nWhich performance would you like to reserve seats for?");
            for (int i = 0; i < performances.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {performances[i].Title}");
            }

            int performanceIndex;
            if (int.TryParse(Console.ReadLine(), out performanceIndex) && performanceIndex > 0 && performanceIndex <= performances.Length)
            {
                return performanceIndex - 1;
            }

            Console.WriteLine("Invalid selection.");
            return -1;
        }

        // Select merchandise
        int GetMerchandiseIndex(Merchandise[] merchandise)
        {
            Console.WriteLine("\nWhich merchandise item would you like to purchase?");
            for (int i = 0; i < merchandise.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {merchandise[i].Name} - ${merchandise[i].Cost} (Stock: {merchandise[i].Stock})");
            }

            int merchandiseIndex;
            if (int.TryParse(Console.ReadLine(), out merchandiseIndex) && merchandiseIndex > 0 && merchandiseIndex <= merchandise.Length)
            {
                return merchandiseIndex - 1;
            }

            Console.WriteLine("Invalid selection.");
            return -1;
        }

        // Display all performances
        void DisplayPerformances(Performance[] performances)
        {
            Console.WriteLine("\nAvailable Performances:");
            foreach (var performance in performances)
            {
                Console.WriteLine(performance.GetDetails());
            }
        }

        // Display all merchandise items
        void DisplayMerchandise(Merchandise[] merchandise)
        {
            Console.WriteLine("\nAvailable Merchandise:");
            foreach (var item in merchandise)
            {
                Console.WriteLine(item.GetDescription());
            }
        }

        // Reserve seats for a selected performance
        void ReserveSeats(Performance[] performances, int performanceIndex, int seatsRequested)
        {
            if (performanceIndex >= 0 && performanceIndex < performances.Length)
            {
                var performance = performances[performanceIndex];
                if (seatsRequested <= performance.AvailableSeats)
                {
                    performance.ReserveSeats(seatsRequested);
                    Console.WriteLine($"You have successfully reserved {seatsRequested} seats for '{performance.Title}'. Total cost: ${seatsRequested * performance.PricePerTicket}");
                }
                else
                {
                    Console.WriteLine("Not enough available seats.");
                }
            }
        }

        // Buy merchandise
        void BuyMerchandise(Merchandise[] merchandise, int merchandiseIndex, int quantity)
        {
            if (merchandiseIndex >= 0 && merchandiseIndex < merchandise.Length)
            {
                var item = merchandise[merchandiseIndex];
                if (quantity <= item.Stock)
                {
                    item.UpdateStock(quantity);  // Update stock after purchase
                    Console.WriteLine($"You have successfully bought {quantity} x {item.Name}. Total cost: ${quantity * item.Cost}");
                }
                else
                {
                    Console.WriteLine($"Sorry, we only have {item.Stock} items in stock.");
                }
            }
        }
    }
}
