namespace Assignment10
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
            // Create an array of Room objects (10 rooms)
            Room[] rooms = new Room[10];
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room(i + 1); // Room numbers 1 through 10
            }

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Book Room\n2. Cancel Room Booking\n3. Display All Rooms\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            // Book a room
                            BookRoom(rooms);
                            break;

                        case 2:
                            // Cancel a room booking
                            CancelRoomBooking(rooms);
                            break;

                        case 3:
                            // Display all room statuses
                            DisplayAllRooms(rooms);
                            break;

                        case 4:
                            // Exit the program
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

        // Method to book a room
        public void BookRoom(Room[] rooms)
        {
            Console.Write("Enter the room number (1-10) to book: ");
            int roomNumber;
            bool validRoom = int.TryParse(Console.ReadLine(), out roomNumber);

            if (validRoom && roomNumber >= 1 && roomNumber <= 10)
            {
                rooms[roomNumber - 1].BookRoom();
            }
            else
            {
                Console.WriteLine("Invalid room number. Please choose a valid room (1-10).");
            }
        }

        // Method to cancel a room booking
        public void CancelRoomBooking(Room[] rooms)
        {
            Console.Write("Enter the room number (1-10) to cancel booking: ");
            int roomNumber;
            bool validRoom = int.TryParse(Console.ReadLine(), out roomNumber);

            if (validRoom && roomNumber >= 1 && roomNumber <= 10)
            {
                rooms[roomNumber - 1].CancelBooking();
            }
            else
            {
                Console.WriteLine("Invalid room number. Please choose a valid room (1-10).");
            }
        }

        // Method to display all room statuses
        public void DisplayAllRooms(Room[] rooms)
        {
            Console.WriteLine("\nRoom Statuses:");
            foreach (var room in rooms)
            {
                room.DisplayRoomStatus();
            }
        }
    }
}
