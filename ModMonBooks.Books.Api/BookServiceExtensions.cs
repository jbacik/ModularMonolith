using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ModMonBooks.Books.Api;
public static class BookServiceExtensions
{
	public static void AddBookServices(
		this IServiceCollection services,
		ConfigurationManager configurationManager)
	{
		string? connectionString = configurationManager.GetConnectionString("BooksDbContext");
		if (connectionString is null) throw new ArgumentNullException("Missing required BooksDbContext connection string");
		
		services.AddDbContext<BooksDbContext>(options =>
		{
			options.UseSqlServer(connectionString);
		});

		services.AddScoped<IBookService, BookService>();
	}
}
