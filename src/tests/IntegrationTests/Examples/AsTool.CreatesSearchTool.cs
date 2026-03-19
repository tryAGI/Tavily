/*
order: 20
title: As Tool Creates Search Tool
slug: as-tool-creates-search-tool
*/

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
}
