namespace Assignment35
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user for the course name and the number of students
            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            // Step 2: Create two arrays to store student names and grades
            string[] studentNames = new string[numOfStudents];
            int[] studentGrades = new int[numOfStudents];

            // Step 3: Get the names and grades from the user
            FillStudentData(studentNames, studentGrades);

            // Step 4: Find the highest grade index and display the corresponding name and grade
            int highestGradeIndex = FindHighestGradeIndex(studentGrades);
            DisplayHighestGrade(studentNames, studentGrades, highestGradeIndex);
        }

        // Method 1: Fill arrays with student names and grades
        void FillStudentData(string[] names, int[] grades)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter the grade for {names[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method 2: Find the index of the student with the highest grade
        int FindHighestGradeIndex(int[] grades)
        {
            int highestGradeIndex = 0;

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestGradeIndex])
                {
                    highestGradeIndex = i;
                }
            }

            return highestGradeIndex;
        }

        // Method 3: Display the student with the highest grade
        void DisplayHighestGrade(string[] names, int[] grades, int highestGradeIndex)
        {
            Console.WriteLine($"The student with the highest grade is {names[highestGradeIndex]} with a grade of {grades[highestGradeIndex]}.");
        }
    }
}
