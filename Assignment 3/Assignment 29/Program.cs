namespace Assignment29
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize the grades array
            int[] grades = { 85, 72, 90, 63, 78, 92, 88, 76, 95, 89 };

            // Step 2: Display the grades statistics
            DisplayGradesStatistics(grades);
        }

        // Method 1: Returns the highest grade in the array
        int GetHighestGrade(int[] grades)
        {
            return grades.Max(); // Uses LINQ Max() to find the highest grade
        }

        // Method 2: Returns the lowest grade in the array
        int GetLowestGrade(int[] grades)
        {
            return grades.Min(); // Uses LINQ Min() to find the lowest grade
        }

        // Method 3: Returns the average grade
        double GetAverageGrade(int[] grades)
        {
            return grades.Average(); // Uses LINQ Average() to find the average grade
        }

        // Method 4: Displays the grades statistics (highest, lowest, and average)
        void DisplayGradesStatistics(int[] grades)
        {
            Console.WriteLine($"Highest Grade: {GetHighestGrade(grades)}");
            Console.WriteLine($"Lowest Grade: {GetLowestGrade(grades)}");
            Console.WriteLine($"Average Grade: {GetAverageGrade(grades):F2}"); // F2 limits the decimal points to 2
        }
    }
}
