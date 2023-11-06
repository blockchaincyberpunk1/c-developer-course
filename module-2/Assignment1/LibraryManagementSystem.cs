using System;

// Base class representing library items
class LibraryItem
{
    public int ItemId { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }

    public LibraryItem(int itemId, string title, int year)
    {
        ItemId = itemId;
        Title = title;
        Year = year;
    }
}

// Derived class for books
class Book : LibraryItem
{
    public string Author { get; set; }
    public int Pages { get; set; }
    public bool IsCheckedOut { get; private set; }

    public Book(int itemId, string title, int year, string author, int pages)
        : base(itemId, title, year)
    {
        Author = author;
        Pages = pages;
        IsCheckedOut = false;
    }

    public void CheckOut()
    {
        if (!IsCheckedOut)
        {
            IsCheckedOut = true;
            Console.WriteLine($"Book '{Title}' by {Author} has been checked out.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is already checked out.");
        }
    }

    public void Return()
    {
        if (IsCheckedOut)
        {
            IsCheckedOut = false;
            Console.WriteLine($"Book '{Title}' by {Author} has been returned.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is not checked out.");
        }
    }
}

// Derived class for DVDs
class DVD : LibraryItem
{
    public string Director { get; set; }
    public TimeSpan Duration { get; set; }

    public DVD(int itemId, string title, int year, string director, TimeSpan duration)
        : base(itemId, title, year)
    {
        Director = director;
        Duration = duration;
    }
}

// Author class
class Author
{
    public string Name { get; set; }

    public Author(string name)
    {
        Name = name;
    }
}

// Patron class
class Patron
{
    public string Name { get; set; }

    public Patron(string name)
    {
        Name = name;
    }

    public void BorrowBook(Book book)
    {
        book.CheckOut();
    }
}

class Program
{
    static void Main()
    {
        // Create instances of LibraryItem, Book, DVD, Author, and Patron classes
        Book book1 = new Book(1, "The Catcher in the Rye", 1951, "J.D. Salinger", 224);
        DVD dvd1 = new DVD(2, "The Shawshank Redemption", 1994, "Frank Darabont", TimeSpan.FromMinutes(142));
        Author author1 = new Author("J.D. Salinger");
        Patron patron1 = new Patron("John");

        // Demonstrate functionality
        patron1.BorrowBook(book1);
        book1.Return();
        patron1.BorrowBook(dvd1);
    }
}

/*  
Explanation:

I designed a class hierarchy with LibraryItem as the base class and Book and DVD as derived classes to represent library items.

I implemented encapsulation using properties to control access to class members.

Constructors are included to initialize object properties when instances are created.

Methods like CheckOut and Return in the Book class demonstrate the functionality within the chosen scenario.
*/
