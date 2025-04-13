namespace Assignment17
{
    public class FoodStall
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public bool IsVegan { get; set; }

        // Constructor to initialize food item details
        public FoodStall(string itemName, double itemPrice, bool isVegan)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            IsVegan = isVegan;
        }

        // Method to get food item details
        public string GetDetails()
        {
            return $"{ItemName} - Price: {ItemPrice:C} - {(IsVegan ? "Vegan" : "Non-Vegan")}";
        }
    }
}
