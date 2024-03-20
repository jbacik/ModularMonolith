namespace ModMonBooks.Books.Api;
public interface IBookService
{
    Task<List<BookResponseModel>> GetBooksAsync();
}
