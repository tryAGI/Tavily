using Microsoft.Extensions.AI;

namespace Tavily.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTool_CreatesSearchTool()
    {
        using var client = CreateTestClient();

        var tool = client.AsSearchTool();

        tool.Should().NotBeNull();
        tool.Name.Should().Be("WebSearch");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public void AsTool_CreatesExtractTool()
    {
        using var client = CreateTestClient();

        var tool = client.AsExtractTool();

        tool.Should().NotBeNull();
        tool.Name.Should().Be("ExtractWebContent");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }

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
