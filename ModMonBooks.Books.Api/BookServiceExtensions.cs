using Microsoft.Extensions.DependencyInjection;

namespace ModMonBooks.Books.Api;
public static class BookServiceExtensions
{
	public static void AddBookServices(this IServiceCollection services)
	{
		services.AddScoped<IBookService, BookService>();
	}
}
