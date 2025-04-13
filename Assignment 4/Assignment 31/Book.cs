namespace Assignment31
{
    public class Book
    {
        // Properties for Title and Author
        public string Title { get; set; }
        public string Author { get; set; }

        // Constructor to initialize Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Method to display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}

