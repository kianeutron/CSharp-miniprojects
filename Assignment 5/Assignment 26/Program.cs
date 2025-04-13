using System;

namespace Assignment26
{
    class Program
    {
        // Start method to create a Book object and display details
        static void Start()
        {
            // Create a Book object with sample data
            Book book = new Book("To Kill a Mockingbird", "Harper Lee");

            // Display the details of the book
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
