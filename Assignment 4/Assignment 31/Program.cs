using System;

namespace Assignment31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start method to execute the program logic
            new Program().Start();
        }

        public void Start()
        {
            // Prompt user for book title and author
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the book author: ");
            string author = Console.ReadLine();

            // Create a new Book object and display its information
            Book book = new Book(title, author);
            book.DisplayBookInfo();
        }
    }
}
