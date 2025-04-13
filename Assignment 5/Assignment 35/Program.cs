using System;

namespace Assignment35
{
    class Program
    {
        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }

        // Start method to handle library operations
        static void Start()
        {
            // Create a Library object
            Library library = new Library();

            // Add books to the library
            library.AddBook("To Kill a Mockingbird");
            library.AddBook("1984");
            library.AddBook("Moby Dick");

            // List all books in the library
            library.ListBooks();
        }
    }
}
