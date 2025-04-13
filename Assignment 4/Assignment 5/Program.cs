namespace Assignment5
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Start method is called from here
            new Program().Start();
        }

        // Start method now handles the main program interaction
        public void Start()
        {
            // Create a list of books for the library
            Book book1 = new Book("The Catcher in the Rye");
            Book book2 = new Book("To Kill a Mockingbird");
            Book book3 = new Book("1984");
            Book book4 = new Book("Moby Dick");

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Borrow Book\n2. Return Book\n3. Display All Books\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    // Handle user inputs
                    switch (choice)
                    {
                        case 1:
                            // Borrow book
                            Console.Write("Enter the title of the book you want to borrow: ");
                            string borrowTitle = Console.ReadLine();
                            BorrowBook(borrowTitle, book1, book2, book3, book4);
                            break;

                        case 2:
                            // Return book
                            Console.Write("Enter the title of the book you want to return: ");
                            string returnTitle = Console.ReadLine();
                            ReturnBook(returnTitle, book1, book2, book3, book4);
                            break;

                        case 3:
                            // Display all books
                            Console.WriteLine("\nLibrary Books:");
                            book1.DisplayDetails();
                            book2.DisplayDetails();
                            book3.DisplayDetails();
                            book4.DisplayDetails();
                            break;

                        case 4:
                            // Exit
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Method to borrow a book based on title
        public void BorrowBook(string title, Book book1, Book book2, Book book3, Book book4)
        {
            if (title.Equals(book1.Title, StringComparison.OrdinalIgnoreCase))
            {
                book1.Borrow();
            }
            else if (title.Equals(book2.Title, StringComparison.OrdinalIgnoreCase))
            {
                book2.Borrow();
            }
            else if (title.Equals(book3.Title, StringComparison.OrdinalIgnoreCase))
            {
                book3.Borrow();
            }
            else if (title.Equals(book4.Title, StringComparison.OrdinalIgnoreCase))
            {
                book4.Borrow();
            }
            else
            {
                Console.WriteLine("Invalid book title.");
            }
        }

        // Method to return a book based on title
        public void ReturnBook(string title, Book book1, Book book2, Book book3, Book book4)
        {
            if (title.Equals(book1.Title, StringComparison.OrdinalIgnoreCase))
            {
                book1.Return();
            }
            else if (title.Equals(book2.Title, StringComparison.OrdinalIgnoreCase))
            {
                book2.Return();
            }
            else if (title.Equals(book3.Title, StringComparison.OrdinalIgnoreCase))
            {
                book3.Return();
            }
            else if (title.Equals(book4.Title, StringComparison.OrdinalIgnoreCase))
            {
                book4.Return();
            }
            else
            {
                Console.WriteLine("Invalid book title.");
            }
        }
    }
}
