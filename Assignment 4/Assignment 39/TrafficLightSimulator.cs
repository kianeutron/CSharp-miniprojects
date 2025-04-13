namespace Assignment39
{
    public class TrafficLightSimulator
    {
        public TrafficLight CurrentLight { get; private set; }

        // Constructor to initialize the traffic light to Red by default
        public TrafficLightSimulator()
        {
            CurrentLight = TrafficLight.Red;
        }

        // Method to set the traffic light to a specific color
        public void SetLight(TrafficLight light)
        {
            CurrentLight = light;
        }

        // Method to display the current traffic light
        public void DisplayCurrentLight()
        {
            Console.WriteLine($"Current Traffic Light: {CurrentLight}");
        }
    }
}
