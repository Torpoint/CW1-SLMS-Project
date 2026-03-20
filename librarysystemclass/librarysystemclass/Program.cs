using System;
using System.Collections.Generic;

public class LibrarySystem
{
    private List<Book> books = new List<Book>();
    private List<User> users = new List<User>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void SearchBook(string title)
    {
        foreach (Book book in books)
        {
            if (book.GetTitle().ToLower().Contains(title.ToLower()))
            {
                Console.WriteLine("Found: " + book.GetTitle() + " | Status: " + book.GetStatus());
            }
        }
    }

    public void ProcessBorrow(Member member, Book book)
    {
        member.BorrowBook(book);
    }

    public void ProcessReturn(Member member, Book book)
    {
        member.ReturnBook(book);
    }
}