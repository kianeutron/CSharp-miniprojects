namespace Assignment26
{
    public class Book
    {
        // Automated properties with public access
        public string Title { get; set; }
        public string Author { get; set; }

        // Constructor to initialize Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
