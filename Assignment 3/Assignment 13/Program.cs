namespace Assignment13
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

            // Step 4: Call CalculateAverage to compute the average grade
            double averageGrade = CalculateAverage(grades);

            // Step 5: Display the average grade
            Console.WriteLine($"The average grade is: {averageGrade}");
        }

        // Method 1: Returns the average grade of the numbers in the array
        double CalculateAverage(int[] grades)
        {
            double sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }
}
