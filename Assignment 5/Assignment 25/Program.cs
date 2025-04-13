using System;

namespace Assignment25
{
    class Program
    {
        // Start method to create a Person object and display their information
        static void Start()
        {
            // Create a Person object with sample data
            Person person = new Person("John Doe", 30);

            // Display the details of the person using properties
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
