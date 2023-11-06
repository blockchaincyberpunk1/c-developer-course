public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already borrowed.");
        }
    }

    public void ReturnBook()
    {
        IsAvailable = true;
        Console.WriteLine($"Book '{Title}' has been returned.");
    }

    public override string ToString()
    {
        return $"Book ID: {BookId}, Title: {Title}, Author: {Author}, Available: {IsAvailable}";
    }
}
