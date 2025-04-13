namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the person's age: ");
            int age = int.Parse(Console.ReadLine());

            string ageCategory = GetAgeCategory(age);
            DisplayAgeCategory(age, ageCategory);
        }

        string GetAgeCategory(int age)
        {
            if (age < 13)
                return "Child";
            else if (age >= 13 && age < 20)
                return "Teenager";
            else if (age >= 20 && age < 60)
                return "Adult";
            else
                return "Senior";
        }

        void DisplayAgeCategory(int age, string category)
        {
            Console.WriteLine($"\nThe person is {age} years old and belongs to the '{category}' age group.");
        }
    }
}
