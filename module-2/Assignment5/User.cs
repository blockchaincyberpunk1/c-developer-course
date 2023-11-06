public class User
{
    public string Name { get; set; }

    public User(string name)
    {
        Name = name;
    }

    public void BorrowBook(Book book)
    {
        Console.WriteLine($"{Name} wants to borrow '{book.Title}'.");

        if (book.IsAvailable)
        {
            book.BorrowBook();
        }
        else
        {
            Console.WriteLine($"Sorry, '{book.Title}' is not available.");
        }
    }

    public void ReturnBook(Book book)
    {
        Console.WriteLine($"{Name} wants to return '{book.Title}'.");
        book.ReturnBook();
    }
}
