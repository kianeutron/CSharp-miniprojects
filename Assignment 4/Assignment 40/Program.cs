using System;

namespace Assignment40
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the EventScheduler with a capacity of 5 events
            EventScheduler eventScheduler = new EventScheduler(5);

            // Prompt the user to enter event details
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Event {i + 1}:");
                Console.Write("Event Name: ");
                string eventName = Console.ReadLine();
                
                Console.Write("Date (e.g., 12/31/2025): ");
                string date = Console.ReadLine();
                
                Console.Write("Location: ");
                string location = Console.ReadLine();
                
                // Create a new event and add it to the scheduler
                Event newEvent = new Event(eventName, date, location);
                eventScheduler.AddEvent(newEvent);
            }

            // Display all scheduled events
            eventScheduler.DisplayEvents();
        }
    }
}
