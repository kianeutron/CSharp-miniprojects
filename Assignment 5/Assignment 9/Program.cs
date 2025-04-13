using System;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Book book = ReadBook();
            book.DisplayBookInfo();
        }

        static Book ReadBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author name: ");
            string author = Console.ReadLine();

            Console.Write("Enter number of pages: ");
            int numberOfPages = Convert.ToInt32(Console.ReadLine());

            return new Book(title, author, numberOfPages);
        }
    }
}
