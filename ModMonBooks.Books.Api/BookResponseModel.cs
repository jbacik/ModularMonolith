namespace ModMonBooks.Books.Api;

public record BookResponseModel(Guid Id, string Isbn, string Title, string Author);