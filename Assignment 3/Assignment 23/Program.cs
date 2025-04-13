namespace Assignment23
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create a boolean array to represent seats (false means unreserved, true means reserved)
            bool[] seats = new bool[10];  // 10 seats available

            // Step 2: Display the initial seat status
            Console.WriteLine("Initial Seat Status:");
            DisplaySeats(seats);

            // Step 3: Simulate reserving a seat
            Console.WriteLine("\nReserving seat 3...");
            ReserveSeat(seats, 3);
            DisplaySeats(seats);

            // Step 4: Simulate releasing a seat
            Console.WriteLine("\nReleasing seat 3...");
            ReleaseSeat(seats, 3);
            DisplaySeats(seats);
        }

        // Method 1: Reserves a specific seat (set the boolean value at the index to true)
        void ReserveSeat(bool[] seats, int seatNumber)
        {
            if (seatNumber >= 0 && seatNumber < seats.Length)
            {
                if (!seats[seatNumber])
                {
                    seats[seatNumber] = true;
                    Console.WriteLine($"Seat {seatNumber + 1} reserved.");
                }
                else
                {
                    Console.WriteLine($"Seat {seatNumber + 1} is already reserved.");
                }
            }
            else
            {
                Console.WriteLine("Invalid seat number.");
            }
        }

        // Method 2: Releases a specific seat (set the boolean value at the index to false)
        void ReleaseSeat(bool[] seats, int seatNumber)
        {
            if (seatNumber >= 0 && seatNumber < seats.Length)
            {
                if (seats[seatNumber])
                {
                    seats[seatNumber] = false;
                    Console.WriteLine($"Seat {seatNumber + 1} released.");
                }
                else
                {
                    Console.WriteLine($"Seat {seatNumber + 1} was not reserved.");
                }
            }
            else
            {
                Console.WriteLine("Invalid seat number.");
            }
        }

        // Method 3: Displays the current seat reservations status
        void DisplaySeats(bool[] seats)
        {
            Console.WriteLine("Current Seat Reservations:");
            for (int i = 0; i < seats.Length; i++)
            {
                string status = seats[i] ? "Reserved" : "Available";
                Console.WriteLine($"Seat {i + 1}: {status}");
            }
        }
    }
}
