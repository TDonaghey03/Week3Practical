class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

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
        //Book 1 information
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456677";
        book.NoOfPages = 200;

        //Book 2 information
        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "839390392";
        book2.NoOfPages = 50;

        //Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();   
    }
}

