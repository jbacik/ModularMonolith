using System.Net;
using System.Net.Http.Json;
using ModMonBooks.Web;

namespace ModMonBooks.Books.Api.Tests.BookEndpoints;

public class ListBooksTests : IClassFixture<WebApplicationFactory<IApiMarker>>
{
	private readonly HttpClient _client;

	public ListBooksTests(WebApplicationFactory<IApiMarker> factory)
	{
		_client = factory.CreateClient();
	}

	[Fact]
	public async Task GetBooks_ReturnsBooksAsync()
	{
		var result = await _client.GetAsync("/books");
		
		result.EnsureSuccessStatusCode();
		result.StatusCode.Should().Be(HttpStatusCode.OK);

		var response = await result.Content.ReadFromJsonAsync<IEnumerable<BookResponseModel>>();
		response!.Count().Should().Be(3);
		response.Should().ContainSingle(b => b.Title == "The Art of Computer Programming");
		response.Should().ContainSingle(b => b.Title == "Introduction to the Theory of Computation");
		response.Should().ContainSingle(b => b.Title == "Introduction to Algorithms");
	}
}
