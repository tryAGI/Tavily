namespace Tavily.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TavilyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TAVILY_API_KEY") ??
            throw new AssertInconclusiveException("TAVILY_API_KEY environment variable is not found.");

        return new TavilyClient(apiKey);
    }

    private static TavilyClient CreateTestClient() => new(apiKey: "test-key");
}
