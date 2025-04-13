using System;

namespace Assignment35
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a library with a capacity of 3 books
            Library library = new Library(3);

            // Add books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new Book("1984", "George Orwell"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            // Attempt to add another book when the library is full
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen"));

            // Display all books in the library
            library.DisplayBooks();
        }
    }
}
