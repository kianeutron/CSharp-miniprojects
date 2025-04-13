using System;

namespace Assignment33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of votes to process
            Console.Write("Enter the number of votes to process: ");
            int numberOfVotes = Convert.ToInt32(Console.ReadLine());

            // Create a VotingSystem object with the specified number of votes
            VotingSystem votingSystem = new VotingSystem(numberOfVotes);

            // Prompt the user to cast votes until all votes are processed
            for (int i = 0; i < numberOfVotes; i++)
            {
                Console.WriteLine($"\nVote {i + 1}:");
                Console.WriteLine("Enter your vote (Yes or No):");

                // Get user input and cast the appropriate vote
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    votingSystem.CastVote(VoteOption.Yes);
                }
                else if (input == "no")
                {
                    votingSystem.CastVote(VoteOption.No);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                    i--;  // Decrease to allow another attempt
                }
            }

            // Display the results of the voting
            votingSystem.DisplayResults();
        }
    }
}
