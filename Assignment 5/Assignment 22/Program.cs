using System;

namespace Assignment22
{
    class Program
    {
        // Start method to simulate the library system
        static void Start()
        {
            // Create a new book object with a quantity of 3
            Book book = new Book("C# Programming", "John Doe", 3);

            // Display the book's info before lending
            book.DisplayBookInfo();

            // Lending books
            Console.WriteLine("\nLending a book...");
            book.LendBook(); // Successfully lend a book

            // Display the book's info after lending
            book.DisplayBookInfo();

            // Try to lend more books than available
            Console.WriteLine("\nTrying to lend another book...");
            book.LendBook();

            // Display the book's info after second lending
            book.DisplayBookInfo();

            // Return a book and display info again
            Console.WriteLine("\nReturning a book...");
            book.ReturnBook();
            book.DisplayBookInfo();
        }

        // Main method to call the Start method
        static void Main(string[] args)
        {
            Start();
        }
    }
}
