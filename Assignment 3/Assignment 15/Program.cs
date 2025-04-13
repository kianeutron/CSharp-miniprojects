namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user how many grades they want to enter
            Console.Write("Enter the number of grades: ");
            int numberOfGrades = int.Parse(Console.ReadLine());

            // Step 2: Create an array to store the grades
            int[] grades = new int[numberOfGrades];

            // Step 3: Ask the user to enter each grade
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            // Step 4: Use GetMaximumGrade to find the highest grade
            int maxGrade = GetMaximumGrade(grades);

            // Step 5: Display the highest grade
            Console.WriteLine($"The highest grade is: {maxGrade}");
        }

        // Method 1: Returns the highest grade in the array
        int GetMaximumGrade(int[] grades)
        {
            int maxGrade = grades[0]; // Start with the first grade as the maximum
            foreach (int grade in grades)
            {
                if (grade > maxGrade)
                {
                    maxGrade = grade; // Update if a higher grade is found
                }
            }
            return maxGrade;
        }
    }
}
