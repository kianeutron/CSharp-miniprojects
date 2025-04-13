
namespace Assignment24
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            List<int> numbers = new List<int>(); // List to store numbers entered by the user

            Console.WriteLine("Enter positive numbers. Enter 0 or a negative number to stop.");
            
            while (true)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                    break; // Exit the loop when the user enters 0 or a negative number
                
                numbers.Add(number); // Add the number to the list
            }

            // If at least one number was entered, calculate and display the average and maximum
            if (numbers.Count > 0)
            {
                double average = CalculateAverage(numbers);
                int maximum = FindMaximum(numbers);
                
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The maximum value is: {maximum}");
            }
            else
            {
                Console.WriteLine("No valid numbers were entered.");
            }
        }

        // Method to calculate the average of a list of numbers
        double CalculateAverage(List<int> numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number; // Add each number to the sum
            }
            return sum / numbers.Count; // Return the average
        }

        // Method to find the maximum value in a list of numbers
        int FindMaximum(List<int> numbers)
        {
            int maximum = numbers[0]; // Assume the first number is the maximum

            foreach (int number in numbers)
            {
                if (number > maximum)
                    maximum = number; // Update maximum if a larger number is found
            }
            
            return maximum;
        }
    }
}
