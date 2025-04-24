namespace Lab7;

class Book
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown Title";
    }

    public Book(string startingTitle)
    {
        title = startingTitle;
    }

    public Book(string startingTitle, string startingAuthor)
    {
        title = startingTitle;
        author = startingAuthor;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Step 1

        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());

        // Step 2

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());

        // Step 3

        Book book3 = new Book("C# Mastery", "Sea Sharp");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());

        // Step 4

        Book book4 = new Book("C# Sensei", "Sea Sharp");
        book4.SetTitle("The Ultimate Guide To C#");
        book4.SetAuthor("C. Sharper");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());
    }
}
