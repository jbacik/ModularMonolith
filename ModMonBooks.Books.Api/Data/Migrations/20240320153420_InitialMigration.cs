using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ModMonBooks.Books.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "books");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "books",
                table: "Books",
                columns: new[] { "Id", "Author", "Isbn", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("022c638f-105f-42aa-9594-ffdd29def50b"), "Michael Sipser", "978-0-201-89683-4", 32.99m, "Introduction to the Theory of Computation" },
                    { new Guid("540adc5c-67b6-4d99-b484-312d26b80914"), "Thomas H. Cormen", "978-0-262-03384-8", 59.77m, "Introduction to Algorithms" },
                    { new Guid("c7d8f1d8-e136-49cf-817f-2d7bfe5f2bc2"), "Donald Knuth", "978-0-306-40615-7", 24.99m, "The Art of Computer Programming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "books");
        }
    }
}
