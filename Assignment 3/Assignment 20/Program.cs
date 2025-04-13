namespace Assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user to enter the number of names to store in the array
            Console.Write("Enter the number of names to store: ");
            int numberOfNames = int.Parse(Console.ReadLine());

            // Step 2: Create a string array to store the names
            string[] names = new string[numberOfNames];

            // Step 3: Use FillNames to allow the user to input the names
            FillNames(names);

            // Step 4: Use DisplayNames to display the list of names
            DisplayNames(names);
        }

        // Method 1: Allows the user to enter the names into the array
        void FillNames(string[] names)
        {
            Console.WriteLine("\nEnter the names:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
        }

        // Method 2: Displays the names in the array
        void DisplayNames(string[] names)
        {
            Console.WriteLine("\nThe names entered are:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
