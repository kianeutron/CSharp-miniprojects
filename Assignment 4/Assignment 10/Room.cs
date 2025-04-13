namespace Assignment10
{
    using System;

    public class Room
    {
        public int RoomNumber { get; set; }
        public bool IsBooked { get; set; }

        // Constructor to initialize room with its number
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsBooked = false; // Initially, rooms are available
        }

        // Method to book a room if available
        public void BookRoom()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Room {RoomNumber} is already booked.");
            }
            else
            {
                IsBooked = true; // Mark the room as booked
                Console.WriteLine($"Room {RoomNumber} has been successfully booked.");
            }
        }

        // Method to cancel a room booking
        public void CancelBooking()
        {
            if (IsBooked)
            {
                IsBooked = false; // Mark the room as available again
                Console.WriteLine($"Room {RoomNumber} booking has been canceled.");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} was not booked.");
            }
        }

        // Method to display the room's status
        public void DisplayRoomStatus()
        {
            Console.WriteLine($"Room {RoomNumber}: {(IsBooked ? "Booked" : "Available")}");
        }
    }
}
