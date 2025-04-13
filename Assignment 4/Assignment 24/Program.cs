namespace Assignment24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example input array of student grades
            int[] grades = { 75, 82, 88, 90, 92, 78 };

            // Call the method to calculate and display the average
            double average = CalculateAverage(grades);
            Console.WriteLine($"Average: {average:F2}");

            // Call the method to display the highest and lowest grades
            DisplayHighestLowest(grades);
        }

        // Method 1: Calculate the average grade
        static double CalculateAverage(int[] grades)
        {
            double sum = 0;

            // Sum all grades
            foreach (var grade in grades)
            {
                sum += grade;
            }

            // Calculate and return the average
            return sum / grades.Length;
        }

        // Method 2: Display the highest and lowest grades
        static void DisplayHighestLowest(int[] grades)
        {
            int highest = grades.Max();
            int lowest = grades.Min();

            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Lowest: {lowest}");
        }
    }
}
