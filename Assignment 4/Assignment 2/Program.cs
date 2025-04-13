namespace Assignment2
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Start method is called from here
            new Program().Start();
        }

        // Start method now handles the main program interaction
        public void Start()
        {
            // Create the course instance
            Course course = new Course("Introduction to Programming", 5);

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Add Student\n2. Remove Student\n3. Display Course Details\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    // Handle user inputs
                    switch (choice)
                    {
                        case 1:
                            // Add student
                            Console.Write("Enter student's name to add: ");
                            string studentToAdd = Console.ReadLine();
                            course.AddStudent(studentToAdd);
                            break;

                        case 2:
                            // Remove student
                            Console.Write("Enter student's name to remove: ");
                            string studentToRemove = Console.ReadLine();
                            course.RemoveStudent(studentToRemove);
                            break;

                        case 3:
                            // Display course details
                            course.DisplayDetails();
                            break;

                        case 4:
                            // Exit
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
