namespace Assignment18
{
    public class Refreshment
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public bool IsAlcoholic { get; set; }

        // Constructor to initialize refreshment details
        public Refreshment(string itemName, double price, bool isAlcoholic)
        {
            ItemName = itemName;
            Price = price;
            IsAlcoholic = isAlcoholic;
        }

        // Method to get refreshment details
        public string GetDescription()
        {
            return $"{ItemName} - Price: {Price:C} - {(IsAlcoholic ? "Alcoholic" : "Non-Alcoholic")}";
        }
    }
}
