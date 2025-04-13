using System;

namespace Assignment19
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user how many terms of the Fibonacci sequence they want
            Console.Write("Enter the number of terms in the Fibonacci sequence: ");
            int terms = int.Parse(Console.ReadLine());

            // Generate and display the Fibonacci sequence
            GenerateFibonacciSequence(terms);
        }

        // Method to generate the Fibonacci sequence
        void GenerateFibonacciSequence(int terms)
        {
            // Handle the case for 0 or 1 terms
            if (terms <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                return;
            }
            
            int first = 0, second = 1;
            
            Console.WriteLine("Fibonacci Sequence:");
            
            // Print the first term (if terms is at least 1)
            if (terms >= 1) Console.Write(first + " ");
            
            // Print the second term (if terms is at least 2)
            if (terms >= 2) Console.Write(second + " ");
            
            // Use a loop to generate and print the rest of the sequence
            for (int i = 3; i <= terms; i++)
            {
                int nextTerm = first + second;
                Console.Write(nextTerm + " ");

                // Update the first and second terms for the next iteration
                first = second;
                second = nextTerm;
            }
            Console.WriteLine(); // For cleaner output
        }
    }
}
