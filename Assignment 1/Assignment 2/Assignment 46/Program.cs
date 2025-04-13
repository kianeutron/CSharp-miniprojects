using System;

namespace Assignment46
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Random number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100.");
            Console.WriteLine("Try to guess it!");

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                // Input validation to make sure the user enters a valid number
                bool validInput = int.TryParse(Console.ReadLine(), out guess);

                if (!validInput)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++;

                // Compare the guess to the target number
                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {targetNumber} correctly in {attempts} attempts.");
                }
            }
        }
    }
}
