#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Tavily;

/// <summary>
/// Extensions for using TavilyClient as an MEAI tool with any IChatClient.
/// </summary>
public static class TavilyToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Tavily search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Tavily client to use for searches.</param>
    /// <param name="maxResults">Maximum number of search results to return (default: 5).</param>
    /// <param name="searchDepth">Search depth (default: Basic).</param>
    /// <param name="includeAnswer">Whether to include an AI-generated answer summary (default: true).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchTool(
        this TavilyClient client,
        int maxResults = 5,
        CreateSearchRequestSearchDepth searchDepth = CreateSearchRequestSearchDepth.Basic,
        bool includeAnswer = true)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateSearchAsync(
                    query: query,
                    maxResults: maxResults,
                    searchDepth: searchDepth,
                    includeAnswer: includeAnswer,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response);
            },
            name: "WebSearch",
            description: "Searches the web for current information on a given query. Returns relevant results with titles, URLs, and content snippets.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Tavily extract,
    /// suitable for extracting content from URLs as a tool.
    /// </summary>
    /// <param name="client">The Tavily client to use for extraction.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsExtractTool(this TavilyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string url, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateExtractAsync(
                    urls: url,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response);
            },
            name: "ExtractWebContent",
            description: "Extracts and returns the main content from a given URL.");
    }

    private static string FormatSearchResponse(CreateSearchResponse response)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(response.Answer))
        {
            parts.Add($"Answer: {response.Answer}");
        }

        if (response.Results is { Count: > 0 })
        {
            parts.Add("Sources:");
            foreach (var result in response.Results)
            {
                var entry = $"- [{result.Title}]({result.Url})";
                if (!string.IsNullOrWhiteSpace(result.Content))
                {
                    entry += $": {result.Content}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }
}
