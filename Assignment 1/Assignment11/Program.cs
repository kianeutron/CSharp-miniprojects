namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1: Convert Celsius to Fahrenheit");
            Console.WriteLine("2: Convert Fahrenheit to Celsius");

            // Get user input for conversion choice
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            // Ask for the temperature value based on the conversion choice
            if (choice == 1)
            {
                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = ConvertFahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
            }
        }

        // Method to convert Celsius to Fahrenheit
        double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Method to convert Fahrenheit to Celsius
        double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
