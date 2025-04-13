namespace Assignment32
{
    public class Person
    {
        // Fields for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display the person's information
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

