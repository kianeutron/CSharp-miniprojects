namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the total score (out of 100): ");
            double score = double.Parse(Console.ReadLine());

            int passPercentage = GetPassPercentage();
            string result = DetermineExamResult(score, passPercentage);

            Console.WriteLine($"Score: {score}%");
            Console.WriteLine($"Result: {result}");
        }

        int GetPassPercentage()
        {
            return 60; // Passing score is 60%
        }

        string DetermineExamResult(double score, int passPercentage)
        {
            if (score >= passPercentage)
                return "Pass";
            else
                return "Fail";
        }
    }
}
