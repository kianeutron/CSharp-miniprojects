namespace Assignment40
{
    public class Event
    {
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        // Constructor to initialize the event's properties
        public Event(string eventName, string date, string location)
        {
            EventName = eventName;
            Date = date;
            Location = location;
        }
    }
}
