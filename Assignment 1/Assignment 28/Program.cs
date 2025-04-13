using System;

namespace Assignment28
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter the percentage grade
            Console.WriteLine("Enter your percentage grade:");
            double percentage = double.Parse(Console.ReadLine());

            // Call the DisplayGradeCategory method to show the grade category
            DisplayGradeCategory(percentage);
        }

        // Method to get the grade category based on the percentage
        string GetGradeCategory(double percentage)
        {
            if (percentage >= 90)
            {
                return "Excellent";
            }
            else if (percentage >= 75)
            {
                return "Good";
            }
            else if (percentage >= 50)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }

        // Method to display the grade category based on the percentage
        void DisplayGradeCategory(double percentage)
        {
            // Call GetGradeCategory to get the category
            string category = GetGradeCategory(percentage);

            // Display the grade category
            Console.WriteLine($"Your grade category is: {category}");
        }
    }
}
