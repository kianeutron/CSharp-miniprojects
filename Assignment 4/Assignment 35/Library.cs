using System;

namespace Assignment35
{
    public class Library
    {
        // Array to store books in the library
        private Book[] books;
        private int currentIndex = 0;

        // Constructor to initialize the array of books with the given capacity
        public Library(int capacity)
        {
            books = new Book[capacity];
        }

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            if (currentIndex < books.Length)
            {
                books[currentIndex] = book;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

        // Method to display all books in the library
        public void DisplayBooks()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books in the Library:");
            for (int i = 0; i < currentIndex; i++)
            {
                books[i].DisplayBookInfo();
            }
        }
    }
}
