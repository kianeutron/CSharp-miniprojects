namespace Assignment1
{
    public class Machine
    {
        // Readonly property for Name
        public string Name { get; }

        // Backing field and read/write property for NumberOfWorkingHours
        private int _numberOfWorkingHours;
        public int NumberOfWorkingHours
        {
            get { return _numberOfWorkingHours; }
            set
            {
                if (value >= 0)
                {
                    _numberOfWorkingHours = value;
                }
            }
        }

        // Constructor to initialize the Machine properties
        public Machine(string name, int numberOfWorkingHours)
        {
            Name = name;
            NumberOfWorkingHours = numberOfWorkingHours >= 0 ? numberOfWorkingHours : 0;
        }

        // Calculated property to check if the machine needs maintenance
        public bool NeedsMaintenance
        {
            get { return NumberOfWorkingHours >= 10000; }
        }

        // Method to display machine details
        public void DisplayInfo()
        {
            Console.WriteLine($"Machine Name: {Name}");
            Console.WriteLine($"Working Hours: {NumberOfWorkingHours}");
            Console.WriteLine($"Needs Maintenance: {(NeedsMaintenance ? "Yes" : "No")}");
        }
    }
}
