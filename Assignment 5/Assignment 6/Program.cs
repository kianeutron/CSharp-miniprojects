namespace Assignment6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Appliance appliance = ReadAppliance(); // Create appliance based on user input
            appliance.DisplayApplianceDetails(); // Display appliance details
        }

        static Appliance ReadAppliance()
        {
            Console.Write("Enter the type of the appliance: ");
            string type = Console.ReadLine();

            int hoursUsed;
            do
            {
                Console.Write("Enter the number of hours used: ");
            } while (!int.TryParse(Console.ReadLine(), out hoursUsed) || hoursUsed < 0);

            return new Appliance(type, hoursUsed); // Return new Appliance object
        }
    }
}
