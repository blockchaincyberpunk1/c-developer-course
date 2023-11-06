using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ListBooks()
    {
        Console.WriteLine("Library Catalog:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
