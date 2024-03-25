using Microsoft.EntityFrameworkCore;
using ModMonBooks.Books.Api.Data;

namespace ModMonBooks.Books.Api;

public class BookService(BooksDbContext dbContext) : IBookService
{
	private readonly BooksDbContext _dbContext = dbContext;

	public async Task<List<BookResponseModel>> GetBooksAsync()
    {
        return await _dbContext.Books
			.Select(b => new BookResponseModel(b.Id, b.Isbn, b.Title, b.Author))
			.ToListAsync();
    }
}