using System;

class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book(1, "The Catcher in the Rye", "J.D. Salinger");
        Book book2 = new Book(2, "To Kill a Mockingbird", "Harper Lee");

        library.AddBook(book1);
        library.AddBook(book2);

        User user1 = new User("Alice");
        User user2 = new User("Bob");

        user1.BorrowBook(book1);
        user2.BorrowBook(book1);

        library.ListBooks();

        user1.ReturnBook(book1);
        library.ListBooks();
    }
}
