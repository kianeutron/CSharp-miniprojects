namespace Assignment9
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public string ShortDescription
        {
            get { return $"{Title} by {Author}"; }
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Number of Pages: {NumberOfPages}");
            Console.WriteLine($"Description: {ShortDescription}");
        }
    }
}
