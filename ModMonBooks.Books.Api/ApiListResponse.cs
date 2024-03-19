namespace ModMonBooks.Books.Api;

public class ApiListResponse<T>  where T : IResponseModel
{
	public List<T>? Data { get; set; }
	public int Total { get; set; } = 0;
	public IDictionary<string, string>? Errors { get; set; } = default!;
}