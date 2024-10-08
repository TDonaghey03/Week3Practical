using System.Net;
using System.Reflection;

class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;    
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        //Output book 1 information to console
        Console.WriteLine("Book information");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book number of pages: {NoOfPages}");
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        //Create instance of book class
        Book book = new Book("C# for beginners","Bill Gates","123455667",200);
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "102918293", 70);

        //Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();   
    }
}

