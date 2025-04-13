namespace Assignment12
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        public void Start()
        {
            // Step 1: Create an array of meals
            Meal[] meals = {
                new Meal("Burger", 5.99, 400),
                new Meal("Pizza", 12.99, 800),
                new Meal("Salad", 4.49, 150),
                new Meal("Pasta", 9.99, 600)
            };

            bool continueOrdering = true;
            double totalCost = 0;
            int totalCalories = 0;

            while (continueOrdering)
            {
                // Step 2: Display meals
                Console.WriteLine("Available Meals:");
                DisplayMeals(meals);

                // Step 3: Ask user to choose a meal
                Console.WriteLine("Enter the meal number to order (or 0 to exit):");
                int mealNumber = int.Parse(Console.ReadLine()) - 1;

                if (mealNumber == -1)
                {
                    // Exit ordering
                    continueOrdering = false;
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (mealNumber >= 0 && mealNumber < meals.Length)
                {
                    // Step 4: Add the meal to the total cost and calories
                    totalCost += meals[mealNumber].Price;
                    totalCalories += meals[mealNumber].Calories;

                    Console.WriteLine($"You ordered {meals[mealNumber].Name}. Total cost for this meal: {meals[mealNumber].Price:C}, Calories: {meals[mealNumber].Calories} kcal.");
                }
                else
                {
                    Console.WriteLine("Invalid meal selection.");
                }

                // Step 5: Ask if the user wants to continue ordering
                Console.WriteLine("Do you want to order more meals? (y/n):");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice != 'y' && choice != 'Y')
                {
                    continueOrdering = false;
                    Console.WriteLine("Exiting...");
                }
            }

            // Step 6: Display the total order cost and total calories
            Console.WriteLine($"\nTotal Cost of your order: {totalCost:C}");
            Console.WriteLine($"Total Calories of your order: {totalCalories} kcal");
        }

        // Method to display all meals
        public void DisplayMeals(Meal[] meals)
        {
            for (int i = 0; i < meals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {meals[i].GetDescription()}");
            }
        }
    }
}
