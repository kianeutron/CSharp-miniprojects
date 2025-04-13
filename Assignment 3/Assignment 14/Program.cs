namespace Assignment14
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

            // Step 4: Set a passing limit
            int passingLimit = 50; // Example: grades above 50 are considered passing

            // Step 5: Use CountPassingGrades to find the number of passing students
            int passingCount = CountPassingGrades(grades, passingLimit);

            // Step 6: Display the result
            Console.WriteLine($"Number of students who passed: {passingCount}");
        }

        // Method 1: Returns the number of students who passed
        int CountPassingGrades(int[] grades, int passingLimit)
        {
            int count = 0;
            foreach (int grade in grades)
            {
                if (grade >= passingLimit)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
