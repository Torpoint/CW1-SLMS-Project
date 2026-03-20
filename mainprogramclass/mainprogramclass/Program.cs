using System;

class Program
{
    static void Main(string[] args)
    {
        LibrarySystem system = new LibrarySystem();

        Member member1 = new Member("M01", "Alice", "1234");
        Librarian librarian1 = new Librarian("L01", "Bob", "admin");

        system.AddUser(member1);
        system.AddUser(librarian1);

        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("Harry Potter", "J.K. Rowling");

        librarian1.AddBook(system, book1);
        librarian1.AddBook(system, book2);

        if (member1.Login("M01", "1234"))
        {
            Console.WriteLine(member1.GetName() + " logged in as " + member1.DisplayRole());

            system.SearchBook("1984");

            system.ProcessBorrow(member1, book1);
            system.ProcessReturn(member1, book1);
        }
        else
        {
            Console.WriteLine("Login failed.");
        }
    }
}