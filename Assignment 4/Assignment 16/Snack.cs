namespace Assignment16
{
    public class Snack
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsCombo { get; set; }

        // Constructor to initialize snack details
        public Snack(string name, double price, bool isCombo)
        {
            Name = name;
            Price = price;
            IsCombo = isCombo;
        }

        // Method to get snack details as a string
        public string GetDetails()
        {
            return $"{Name} - Price: {Price:C} - {(IsCombo ? "Combo" : "Regular")}";
        }
    }
}
