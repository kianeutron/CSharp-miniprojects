using System;

namespace Assignment32
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start method to execute the program logic
            new Program().Start();
        }

        public void Start()
        {
            // Create an array of 3 Person objects
            Person[] persons = new Person[3];

            // Populate the array by asking the user for details
            for (int i = 0; i < persons.Length; i++)
            {
                // Prompt user for Name and Age of each Person
                Console.WriteLine($"Enter details for person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Create a new Person object and store it in the array
                persons[i] = new Person(name, age);
            }

            // Call the method to display the details of all persons
            PrintPersonArray(persons);
        }

        // Method to print all persons in the array
        public void PrintPersonArray(Person[] persons)
        {
            Console.WriteLine("\nPerson details:");
            foreach (Person person in persons)
            {
                person.DisplayPersonInfo();
            }
        }
    }
}
