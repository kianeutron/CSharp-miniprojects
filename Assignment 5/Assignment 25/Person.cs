namespace Assignment25
{
    public class Person
    {
        // Private fields
        private string _name;
        private int _age;

        // Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        // Public properties to access and modify the private fields
        public string Name
        {
            get { return _name; }  // Getter for Name
            set { _name = value; } // Setter for Name
        }

        public int Age
        {
            get { return _age; }   // Getter for Age
            set { _age = value; }  // Setter for Age
        }
    }
}
