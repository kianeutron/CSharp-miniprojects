namespace Assignment5
{
    using System;

    public class Book
    {
        // Fields for title and availability status
        public string Title { get; set; }
        public bool IsAvailable { get; private set; }

        // Constructor to initialize the book with a title and set it as available by default
        public Book(string title)
        {
            Title = title;
            IsAvailable = true;
        }

        // Method to borrow a book if available
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have successfully borrowed \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" is currently unavailable.");
            }
        }

        // Method to return a book
        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"You have successfully returned \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"\"{Title}\" was not borrowed.");
            }
        }

        // Method to display book details (title and availability)
        public void DisplayDetails()
        {
            string availability = IsAvailable ? "Available" : "Unavailable";
            Console.WriteLine($"Title: \"{Title}\" | Status: {availability}");
        }
    }
}
