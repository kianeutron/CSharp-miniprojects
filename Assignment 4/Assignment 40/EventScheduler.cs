namespace Assignment40
{
    public class EventScheduler
    {
        public Event[] Events { get; private set; }
        private int currentIndex;

        // Constructor to initialize the array of events with the given capacity
        public EventScheduler(int capacity)
        {
            Events = new Event[capacity];
            currentIndex = 0;
        }

        // Method to add an event to the scheduler
        public void AddEvent(Event eventObj)
        {
            if (currentIndex < Events.Length)
            {
                Events[currentIndex] = eventObj;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("The scheduler is full. Cannot add more events.");
            }
        }

        // Method to display all scheduled events
        public void DisplayEvents()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("No events scheduled.");
                return;
            }

            Console.WriteLine("Scheduled Events:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine($"{i + 1}. {Events[i].EventName} - {Events[i].Date} - {Events[i].Location}");
            }
        }
    }
}
