using Microsoft.EntityFrameworkCore;
using ModMonBooks.Books.Api.Entities;

namespace ModMonBooks.Books.Api.Data;
public class BooksDbContext : DbContext
{
	internal virtual DbSet<Book> Books { get; set; } = default!;
	public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("books");

		modelBuilder.Entity<Book>(entity =>
		{
			entity.HasKey(e => e.Id);
			entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
			entity.Property(e => e.Isbn).IsRequired().HasMaxLength(20);
			entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
		});

		modelBuilder.Entity<Book>().HasData(
			ArtOfComputerProgramming,
			IntroToComputerTheory,
			IntroToAlgorithms);
	}


	#region Sample Data
	private static Book ArtOfComputerProgramming = new Book(
		Guid.Parse("c7d8f1d8-e136-49cf-817f-2d7bfe5f2bc2"),
		"978-0-306-40615-7",
		"The Art of Computer Programming",
		"Donald Knuth",
		24.99m);

	private static Book IntroToComputerTheory = new Book(
	Guid.Parse("022c638f-105f-42aa-9594-ffdd29def50b"),
	"978-0-201-89683-4",
	"Introduction to the Theory of Computation",
	"Michael Sipser",
	32.99m);

	private static Book IntroToAlgorithms = new Book(
		Guid.Parse("540adc5c-67b6-4d99-b484-312d26b80914"),
		"978-0-262-03384-8",
		"Introduction to Algorithms",
		"Thomas H. Cormen",
		59.77m);
	#endregion
}

