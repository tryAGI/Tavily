/*
order: 10
title: As Tool Creates Extract Tool
slug: as-tool-creates-extract-tool
*/

using Microsoft.Extensions.AI;

namespace Tavily.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTool_CreatesExtractTool()
    {
        using var client = CreateTestClient();

        var tool = client.AsExtractTool();

        tool.Should().NotBeNull();
        tool.Name.Should().Be("ExtractWebContent");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }
}
