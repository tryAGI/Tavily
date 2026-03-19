# As Tool Search Returns Results



This example assumes `using Tavily;` is in scope and `apiKey` contains your Tavily API key.

```csharp
using var client = new TavilyClient(apiKey);

var tool = client.AsSearchTool(maxResults: 3);
var result = await tool.InvokeAsync(
    new AIFunctionArguments(new Dictionary<string, object?>
    {
        ["query"] = "latest .NET release",
    }));

var text = result?.ToString();
```