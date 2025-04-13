namespace Assignment12
{
    using System;

    public class Meal
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Calories { get; set; }

        // Constructor to initialize meal details
        public Meal(string name, double price, int calories)
        {
            Name = name;
            Price = price;
            Calories = calories;
        }

        // Method to get the meal description
        public string GetDescription()
        {
            return $"{Name} - Price: {Price:C} - Calories: {Calories} kcal";
        }
    }
}
