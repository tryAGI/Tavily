```csharp
var apiKey =
    Environment.GetEnvironmentVariable("TAVILY_API_KEY") ??
    throw new AssertInconclusiveException("TAVILY_API_KEY environment variable is not found.");

using var client = new TavilyClient(apiKey);

Response searchResponse = await client.CreateSearchAsync(
    query: "Who is Leo Messi?");

foreach (var result in searchResponse.Results)
{
    Console.WriteLine($"Title: {result.Title}");
    Console.WriteLine($"Content: {result.Content}");
    Console.WriteLine($"Score: {result.Score}");
    Console.WriteLine($"Url: {result.Url}");
    Console.WriteLine();
}
```