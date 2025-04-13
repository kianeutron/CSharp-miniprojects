using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            // Create a Machine object using the ReadMachine method
            Machine machine = ReadMachine();

            // Display the Machine's details using the DisplayInfo method
            machine.DisplayInfo();
        }

        // Method to read user input and create a Machine object
        static Machine ReadMachine()
        {
            Console.Write("Enter the machine's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of working hours: ");
            int hours = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out hours) && hours >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid non-negative number for working hours.");
                }
            }

            // Create and return a new Machine object
            return new Machine(name, hours);
        }
    }
}
