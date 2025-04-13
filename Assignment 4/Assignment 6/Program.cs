namespace Assignment6
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
            // Create some students
            Student student1 = new Student("Alice");
            Student student2 = new Student("Bob");
            Student student3 = new Student("Charlie");

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Assign Grade\n2. Display Grade\n3. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    // Handle user inputs
                    switch (choice)
                    {
                        case 1:
                            // Assign grade
                            Console.Write("Enter the name of the student (Alice, Bob, Charlie): ");
                            string studentName = Console.ReadLine();
                            Console.Write("Enter the grade (0-100): ");
                            double grade;
                            bool validGrade = double.TryParse(Console.ReadLine(), out grade);
                            
                            if (validGrade)
                            {
                                AssignGradeToStudent(studentName, grade, student1, student2, student3);
                            }
                            else
                            {
                                Console.WriteLine("Invalid grade input.");
                            }
                            break;

                        case 2:
                            // Display grade
                            Console.Write("Enter the name of the student (Alice, Bob, Charlie): ");
                            string displayName = Console.ReadLine();
                            DisplayGradeOfStudent(displayName, student1, student2, student3);
                            break;

                        case 3:
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

        // Method to assign a grade to a student by name
        public void AssignGradeToStudent(string name, double grade, Student student1, Student student2, Student student3)
        {
            if (name.Equals(student1.Name, StringComparison.OrdinalIgnoreCase))
            {
                student1.AssignGrade(grade);
            }
            else if (name.Equals(student2.Name, StringComparison.OrdinalIgnoreCase))
            {
                student2.AssignGrade(grade);
            }
            else if (name.Equals(student3.Name, StringComparison.OrdinalIgnoreCase))
            {
                student3.AssignGrade(grade);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Method to display the grade of a student by name
        public void DisplayGradeOfStudent(string name, Student student1, Student student2, Student student3)
        {
            if (name.Equals(student1.Name, StringComparison.OrdinalIgnoreCase))
            {
                student1.DisplayGrade();
            }
            else if (name.Equals(student2.Name, StringComparison.OrdinalIgnoreCase))
            {
                student2.DisplayGrade();
            }
            else if (name.Equals(student3.Name, StringComparison.OrdinalIgnoreCase))
            {
                student3.DisplayGrade();
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
