namespace ModMonBooks.Books.Api;
public interface IBookService
{
    IEnumerable<BookResponseModel> GetBooks();
}
