using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModMonBooks.Books.Api;

public static class BookEndpoints
{
    public static void MapBookEndpoints(this WebApplication app)
    {
        app.MapGet("/books", (IBookService service) => service.GetBooks());
    }

    public static void AddBookServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
    }
}
