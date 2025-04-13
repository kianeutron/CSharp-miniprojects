namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Smartphone phone = ReadSmartphone(); // Get smartphone details
            phone.DisplayPhoneDetails(); // Display the smartphone details
        }

        static Smartphone ReadSmartphone()
        {
            Console.Write("Enter the brand of the smartphone: ");
            string brand = Console.ReadLine();

            int totalStorage;
            do
            {
                Console.Write("Enter the total storage capacity (in GB): ");
            } while (!int.TryParse(Console.ReadLine(), out totalStorage) || totalStorage <= 0);

            int usedStorage;
            do
            {
                Console.Write("Enter the used storage (in GB): ");
            } while (!int.TryParse(Console.ReadLine(), out usedStorage) || usedStorage < 0 || usedStorage > totalStorage);

            return new Smartphone(brand, totalStorage, usedStorage); // Return new Smartphone object
        }
    }
}
