using FastEndpoints;

namespace ModMonBooks.Books.Api;
public class BooksListEndpoint(IBookService bookService) : EndpointWithoutRequest<ApiListResponse<BookResponseModel>>
{
	private readonly IBookService _bookService = bookService;

	public override void Configure()
	{
		Get("/api/books");
		AllowAnonymous();
	}

	public override async Task HandleAsync(CancellationToken cancellationToken = default)
	{
		var list = _bookService.GetBooks();
		var result = new ApiListResponse<BookResponseModel>
		{
			Data = list.ToList(),
			Total = list.Count()
		};

		await SendAsync(result);
	}
}
