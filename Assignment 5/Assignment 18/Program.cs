using System;

namespace Assignment18
{
    class Program
    {
        static void Start()
        {
            // Create a new Student object
            Student student = new Student("John Doe", 20, 3.75);

            // Display student details
            student.DisplayDetails();
        }

        static void Main(string[] args)
        {
            // Call the Start method to initiate program
            Start();
        }
    }
}
