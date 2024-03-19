namespace ModMonBooks.Books.Api;

public class BookService : IBookService
{
    public IEnumerable<BookResponseModel> GetBooks()
    {
        return new[]
        {
            new BookResponseModel(Guid.NewGuid(), "978-0-306-40615-7", "The Art of Computer Programming", "Donald Knuth"),
            new BookResponseModel(Guid.NewGuid(), "978-0-201-89683-4", "Introduction to the Theory of Computation", "Michael Sipser"),
            new BookResponseModel(Guid.NewGuid(), "978-0-262-03384-8", "Introduction to Algorithms", "Thomas H. Cormen"),
        };
    }
}