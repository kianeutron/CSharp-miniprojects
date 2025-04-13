namespace Assignment22
{
    public class Book
    {
        // Readonly properties for Title and Author, can only be set via constructor
        public string Title { get; }
        public string Author { get; }

        // Read/Write property for Quantity of books available in the library
        public int Quantity { get; set; }

        // Constructor to initialize Title, Author, and Quantity
        public Book(string title, string author, int quantity)
        {
            Title = title;
            Author = author;
            Quantity = quantity;
        }

        // Method to lend a book (decreases quantity by 1)
        public bool LendBook()
        {
            if (Quantity > 0)
            {
                Quantity--;
                return true; // Book successfully lent
            }
            else
            {
                Console.WriteLine("Sorry, the book is currently unavailable.");
                return false; // No books available for lending
            }
        }

        // Method to return a book (increases quantity by 1)
        public void ReturnBook()
        {
            Quantity++;
        }

        // Method to display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nQuantity: {Quantity}");
        }
    }
}
