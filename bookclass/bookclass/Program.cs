using System;

public class Book
{
    private string title;
    private string author;
    private string status;
    private DateTime? dueDate;
    private Member reservedBy;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.status = "Available";
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetStatus()
    {
        return status;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public bool Borrow(Member member)
    {
        if (status == "Available")
        {
            status = "Borrowed";
            dueDate = DateTime.Now.AddDays(14);
            return true;
        }
        return false;
    }

    public void ReturnBook()
    {
        if (reservedBy != null)
        {
            status = "Reserved";
        }
        else
        {
            status = "Available";
        }

        dueDate = null;
    }

    public void Reserve(Member member)
    {
        if (status == "Borrowed")
        {
            reservedBy = member;
            status = "Reserved";
        }
    }
}