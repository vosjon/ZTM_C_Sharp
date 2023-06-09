Book book1 = new Book("Harry Potter and the Socerer's Stone", "J.K. Rowling"); 
book1.PrintSummary();

Book book2 = new Book("Clear Communication - Overcome Approach Anxiety, Meet New People, and Resolve Conflicts", "Jonathan Vos");
book2.PrintSummary();
int titleLength = book1.GetTitleLengthWithoutWhitespaces();
Console.WriteLine(titleLength);

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"{Title} - {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLengthWithoutWhitespaces()
    {
        string titleWithoutWhitespaces = Title.Replace(" ", "");
        return titleWithoutWhitespaces.Length;
    }
}