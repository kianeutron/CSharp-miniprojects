namespace Assignment27
{
    public class Car
    {
        // Private fields
        private string _make;
        private string _model;
        private int _year;

        // Constructor to initialize Make, Model, and Year
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        // Public property for Make (readonly)
        public string Make
        {
            get { return _make; }
        }

        // Public property for Model (readonly)
        public string Model
        {
            get { return _model; }
        }

        // Public property for Year (read/write)
        public int Year
        {
            get { return _year; }
            set
            {
                // If the year is negative, do not change the value
                if (value >= 0)
                {
                    _year = value;
                }
            }
        }

        // Method to display car details
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Car Year: {Year}");
        }
    }
}
