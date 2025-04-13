namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();  // Start the seat booking process
        }

        // Start method that drives the entire booking logic
        void Start()
        {
            // Step 1: Create and initialize the seats array (10 seats)
            bool[] seats = new bool[10];
            InitializeSeats(seats);

            // Step 2: Display initial seats arrangement
            Console.WriteLine("Initial Seats Arrangement:");
            DisplaySeats(seats);

            // Step 3: Ask the user to book a seat
            Console.WriteLine("\nEnter the seat number you want to book (1-10):");
            int seatNumber = int.Parse(Console.ReadLine()) - 1;

            // Step 4: Book the selected seat
            BookSeat(seats, seatNumber);

            // Step 5: Display updated seats arrangement
            Console.WriteLine("\nUpdated Seats Arrangement:");
            DisplaySeats(seats);
        }

        // Method 1: Initialize the seats with random availability (true: available, false: booked)
        void InitializeSeats(bool[] seats)
        {
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = random.Next(0, 2) == 0; // Randomly set to true or false
            }
        }

        // Method 2: Display the current seat arrangement
        void DisplaySeats(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                Console.WriteLine($"Seat {i + 1}: {(seats[i] ? "Available" : "Booked")}");
            }
        }

        // Method 3: Book a seat if it is available
        void BookSeat(bool[] seats, int seatNumber)
        {
            if (seatNumber >= 0 && seatNumber < seats.Length)
            {
                if (seats[seatNumber])
                {
                    seats[seatNumber] = false; // Mark the seat as booked
                    Console.WriteLine($"Seat {seatNumber + 1} has been booked.");
                }
                else
                {
                    Console.WriteLine($"Seat {seatNumber + 1} is already booked.");
                }
            }
            else
            {
                Console.WriteLine("Invalid seat number.");
            }
        }
    }
}
