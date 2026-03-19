/*
order: 30
title: As Tool Search Returns Results
slug: as-tool-search-returns-results
*/

using Microsoft.Extensions.AI;

namespace Tavily.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task AsTool_SearchReturnsResults()
    {
        using var client = GetAuthenticatedClient();

        var tool = client.AsSearchTool(maxResults: 3);
        var result = await tool.InvokeAsync(
            new AIFunctionArguments(new Dictionary<string, object?>
            {
                ["query"] = "latest .NET release",
            }));

        result.Should().NotBeNull();
        var text = result?.ToString();
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("Sources:");
    }
}
