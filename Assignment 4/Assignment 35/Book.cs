namespace Assignment35
{
    public class Book
    {
        // Fields for book title and author
        public string Title { get; set; }
        public string Author { get; set; }

        // Constructor to initialize a book
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Method to display book details
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}

