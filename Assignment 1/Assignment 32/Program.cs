using System;

namespace Assignment32
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter a day of the week
            Console.WriteLine("Enter a day of the week:");
            string day = Console.ReadLine().Trim().ToLower(); // Convert to lowercase for consistency

            // Call the DisplayDayType method to check and display if it's a weekend or weekday
            DisplayDayType(day);
        }

        // Method to check if the given day is a weekend or a weekday
        bool IsWeekend(string day)
        {
            // Check if the day is Saturday or Sunday
            return day == "saturday" || day == "sunday";
        }

        // Method to display whether the given day is a weekend or a weekday
        void DisplayDayType(string day)
        {
            if (IsWeekend(day))
            {
                Console.WriteLine($"{day} is a weekend.");
            }
            else
            {
                Console.WriteLine($"{day} is a weekday.");
            }
        }
    }
}
