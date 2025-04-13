using System;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to input a positive number for the countdown
            Console.Write("Enter a positive number for the countdown: ");
            int number = int.Parse(Console.ReadLine());

            // Ensure the number is positive, then start the countdown
            if (number > 0)
            {
                StartCountdown(number);
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
            }
        }

        // Method to perform the countdown from the entered number down to 1
        void StartCountdown(int number)
        {
            // Loop to decrement the number and display each step
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Countdown finished!");
        }
    }
}
