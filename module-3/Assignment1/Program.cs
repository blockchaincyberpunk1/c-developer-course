using System;
using NamespaceDemo.Books; // Import the Books namespace
using NamespaceDemo.Users; // Import the Users namespace

namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of classes from different namespaces
            var book = new Book
            {
                Title = "Sample Book",
                Author = "John Doe"
            };

            var user = new User
            {
                Name = "Alice",
                Age = 30
            };

            // Display information from different namespaces
            Console.WriteLine($"Book: {book.Title} by {book.Author}");
            Console.WriteLine($"User: {user.Name}, Age: {user.Age}");
        }
    }
}
