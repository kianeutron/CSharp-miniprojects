namespace Assignment8
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
            // Create an array to store 10 seats
            Seat[] seats = new Seat[10];
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = new Seat(i + 1); // Initialize seat numbers 1 to 10
            }

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Book Seat\n2. Cancel Booking\n3. Display All Seats\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            // Book a seat
                            BookSeat(seats);
                            break;

                        case 2:
                            // Cancel seat booking
                            CancelBooking(seats);
                            break;

                        case 3:
                            // Display all seats status
                            DisplayAllSeats(seats);
                            break;

                        case 4:
                            // Exit program
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Method to book a seat
        public void BookSeat(Seat[] seats)
        {
            Console.Write("Enter the seat number (1-10) to book: ");
            int seatNumber = int.Parse(Console.ReadLine()) - 1;

            if (seatNumber >= 0 && seatNumber < seats.Length)
            {
                seats[seatNumber].BookSeat();
            }
            else
            {
                Console.WriteLine("Invalid seat number.");
            }
        }

        // Method to cancel a booking
        public void CancelBooking(Seat[] seats)
        {
            Console.Write("Enter the seat number (1-10) to cancel: ");
            int seatNumber = int.Parse(Console.ReadLine()) - 1;

            if (seatNumber >= 0 && seatNumber < seats.Length)
            {
                seats[seatNumber].CancelBooking();
            }
            else
            {
                Console.WriteLine("Invalid seat number.");
            }
        }

        // Method to display all seats' statuses
        public void DisplayAllSeats(Seat[] seats)
        {
            Console.WriteLine("\nSeats Status:");
            foreach (var seat in seats)
            {
                seat.DisplaySeatStatus();
            }
        }
    }
}
