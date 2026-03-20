using System;

public class User
{
    // Encapsulation (private fields)
    private string userID;
    private string name;
    private string password;

    public User(string userID, string name, string password)
    {
        this.userID = userID;
        this.name = name;
        this.password = password;
    }

    public bool Login(string inputID, string inputPassword)
    {
        return userID == inputID && password == inputPassword;
    }

    // Polymorphism (virtual method)
    public virtual string DisplayRole()
    {
        return "User";
    }

    public string GetName()
    {
        return name;
    }
}