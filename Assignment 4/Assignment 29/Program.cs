using System;

namespace Assignment29
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
            // Prompt the user to enter a day of the week
            Console.WriteLine("Enter a day of the week (e.g., Monday):");
            string input = Console.ReadLine();

            try
            {
                // Convert the input string to the corresponding enum value
                Day day = (Day)Enum.Parse(typeof(Day), input, true); // true allows case-insensitive parsing

                // Use a switch statement based on the Day enum value
                switch (day)
                {
                    case Day.Monday:
                        Console.WriteLine("It's the start of the week! Get ready for the challenges ahead.");
                        break;
                    case Day.Tuesday:
                        Console.WriteLine("It's Tuesday! Keep the momentum going.");
                        break;
                    case Day.Wednesday:
                        Console.WriteLine("It's Wednesday! You're halfway through the week.");
                        break;
                    case Day.Thursday:
                        Console.WriteLine("It's Thursday! Almost there!");
                        break;
                    case Day.Friday:
                        Console.WriteLine("It's Friday! The weekend is almost here.");
                        break;
                    case Day.Saturday:
                        Console.WriteLine("It's Saturday! Time to relax or have some fun.");
                        break;
                    case Day.Sunday:
                        Console.WriteLine("It's Sunday! Rest and recharge for the upcoming week.");
                        break;
                    default:
                        Console.WriteLine("Invalid day.");
                        break;
                }
            }
            catch (ArgumentException)
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid day (e.g., Monday, Tuesday, etc.).");
            }
        }
    }
}
