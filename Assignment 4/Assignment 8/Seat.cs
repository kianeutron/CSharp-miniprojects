namespace Assignment8
{
    using System;

    public class Seat
    {
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; }

        // Constructor to initialize a seat with a number and availability status
        public Seat(int seatNumber)
        {
            SeatNumber = seatNumber;
            IsBooked = false; // Initially, all seats are unbooked
        }

        // Method to book the seat
        public void BookSeat()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Seat {SeatNumber} is already booked.");
            }
            else
            {
                IsBooked = true;
                Console.WriteLine($"Seat {SeatNumber} has been successfully booked.");
            }
        }

        // Method to cancel the seat booking
        public void CancelBooking()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"Seat {SeatNumber} is not booked.");
            }
            else
            {
                IsBooked = false;
                Console.WriteLine($"Booking for seat {SeatNumber} has been canceled.");
            }
        }

        // Method to display the seat status
        public void DisplaySeatStatus()
        {
            Console.WriteLine($"Seat {SeatNumber}: {(IsBooked ? "Booked" : "Available")}");
        }
    }
}
