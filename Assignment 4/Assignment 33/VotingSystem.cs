namespace Assignment33
{
    public class VotingSystem
    {
        // Array to store votes
        private VoteOption[] votes;
        private int voteCount;

        // Constructor to initialize the array based on the number of votes
        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            voteCount = 0;  // Track the current vote count
        }

        // Method to cast a vote (add a vote to the array)
        public void CastVote(VoteOption vote)
        {
            if (voteCount < votes.Length)
            {
                votes[voteCount] = vote;
                voteCount++;
            }
            else
            {
                Console.WriteLine("All votes have already been cast.");
            }
        }

        // Method to display the number of Yes and No votes
        public void DisplayResults()
        {
            int yesVotes = 0;
            int noVotes = 0;

            // Calculate the number of Yes and No votes
            foreach (var vote in votes)
            {
                if (vote == VoteOption.Yes)
                {
                    yesVotes++;
                }
                else if (vote == VoteOption.No)
                {
                    noVotes++;
                }
            }

            // Display the results
            Console.WriteLine($"Total Yes votes: {yesVotes}");
            Console.WriteLine($"Total No votes: {noVotes}");
        }
    }
}
