namespace ModMonBooks.Books.Api.Entities;
internal class Book
{
	public Guid Id { get; private set; } = Guid.NewGuid();
	public string Isbn { get; private set; } = string.Empty;
	public string Title { get; private set; } = string.Empty;
	public string Author { get; private set; } = string.Empty;
	public decimal Price { get; private set; } = 0.0m;

	public Book(Guid id, string isbn, string title, string author, decimal price)
	{
		this.Id = id;
		this.Isbn = isbn;
		this.Title = title;
		this.Author = author;
		this.Price = price;
	}
}
