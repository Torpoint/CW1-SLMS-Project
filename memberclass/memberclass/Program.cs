using System.Collections.Generic;

public class Member : User
{
    private List<Book> borrowedBooks = new List<Book>();
    private List<Book> reservedBooks = new List<Book>();

    public Member(string userID, string name, string password)
        : base(userID, name, password) { }

    // Polymorphism (override)
    public override string DisplayRole()
    {
        return "Member";
    }

    public void BorrowBook(Book book)
    {
        if (borrowedBooks.Count >= 5)
        {
            Console.WriteLine("Borrow limit reached (5 books).");
            return;
        }

        if (book.Borrow(this))
        {
            borrowedBooks.Add(book);
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            borrowedBooks.Remove(book);
            book.ReturnBook();
            Console.WriteLine("Book returned successfully.");
        }
        else
        {
            Console.WriteLine("This book is not in your borrowed list.");
        }
    }

    public void ReserveBook(Book book)
    {
        if (book.GetStatus() == "Borrowed")
        {
            book.Reserve(this);
            reservedBooks.Add(book);
            Console.WriteLine("Book reserved successfully.");
        }
        else
        {
            Console.WriteLine("Book is available — no need to reserve.");
        }
    }
}