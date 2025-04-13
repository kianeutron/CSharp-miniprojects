using System;
using System.Collections.Generic;

namespace Assignment35
{
    public class Library
    {
        // Private field for storing book collection
        private List<string> _books;

        // Constructor: Initializes the book collection
        public Library()
        {
            _books = new List<string>();
        }

        // Method to add a book to the collection
        public void AddBook(string bookName)
        {
            if (!string.IsNullOrEmpty(bookName))
            {
                _books.Add(bookName);
                Console.WriteLine($"Book '{bookName}' added to the collection.");
            }
            else
            {
                Console.WriteLine("Book name cannot be empty.");
            }
        }

        // Method to list all books in the collection
        public void ListBooks()
        {
            if (_books.Count > 0)
            {
                Console.WriteLine("Books in the collection:");
                foreach (var book in _books)
                {
                    Console.WriteLine($"- {book}");
                }
            }
            else
            {
                Console.WriteLine("No books in the collection.");
            }
        }
    }
}

