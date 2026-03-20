using System;

public class Librarian : User
{
    public Librarian(string userID, string name, string password)
        : base(userID, name, password) { }

    public override string DisplayRole()
    {
        return "Librarian";
    }

    public void AddBook(LibrarySystem system, Book book)
    {
        system.AddBook(book);
        Console.WriteLine("Book added to system.");
    }

    public void RemoveBook(LibrarySystem system, Book book)
    {
        system.RemoveBook(book);
        Console.WriteLine("Book removed from system.");
    }

    public void UpdateBook(Book book, string newTitle, string newAuthor)
    {
        book.SetTitle(newTitle);
        book.SetAuthor(newAuthor);
        Console.WriteLine("Book updated.");
    }
}