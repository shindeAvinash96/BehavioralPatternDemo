public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }
}
public class Bookshelf
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}

public interface IBookIterator
{
    bool HasNext();     // Do we have a next book?
    Book Next();        // Give me the next book
}

public class BookshelfIterator : IBookIterator
{
    private Bookshelf shelf;
    private int index = 0;

    public BookshelfIterator(Bookshelf shelf)
    {
        this.shelf = shelf;
    }

    public bool HasNext()
    {
        return index < shelf.GetBooks().Count;
    }

    public Book Next()
    {
        return shelf.GetBooks()[index++];
    }
}




class Program
{
    static void Main()
    {
        Bookshelf shelf = new Bookshelf();
        shelf.AddBook(new Book("Harry Potter"));
        shelf.AddBook(new Book("Lord of the Rings"));
        shelf.AddBook(new Book("The Hobbit"));

        BookshelfIterator iterator = new BookshelfIterator(shelf);

        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book.Title);
        }
    }
}
