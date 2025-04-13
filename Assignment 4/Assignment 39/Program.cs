using System;

namespace Assignment39
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the TrafficLightSimulator class
            TrafficLightSimulator trafficLightSimulator = new TrafficLightSimulator();

            // Display the current light
            trafficLightSimulator.DisplayCurrentLight();

            // Change to Yellow and display
            trafficLightSimulator.SetLight(TrafficLight.Yellow);
            trafficLightSimulator.DisplayCurrentLight();

            // Change to Green and display
            trafficLightSimulator.SetLight(TrafficLight.Green);
            trafficLightSimulator.DisplayCurrentLight();

            // Change back to Red and display
            trafficLightSimulator.SetLight(TrafficLight.Red);
            trafficLightSimulator.DisplayCurrentLight();
        }
    }
}
