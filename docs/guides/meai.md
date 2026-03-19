# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Tavily SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models web search and content extraction capabilities.

## Installation

```bash
dotnet add package tryAGI.Tavily
```

## Web Search Tool

Use `AsSearchTool()` to create an `AIFunction` that wraps Tavily search. Pass it to any `IChatClient` via `ChatOptions.Tools`.

```csharp
using Microsoft.Extensions.AI;
using Tavily;

// Create the Tavily search tool
var tavilyClient = new TavilyClient(
    apiKey: Environment.GetEnvironmentVariable("TAVILY_API_KEY")!);

AIFunction searchTool = tavilyClient.AsSearchTool(
    maxResults: 5,
    searchDepth: RequestSearchDepth.Basic,
    includeAnswer: true);

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [searchTool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What are the latest developments in .NET 10?"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Content Extraction Tool

Use `AsExtractTool()` to create an `AIFunction` that extracts content from URLs.

```csharp
using Microsoft.Extensions.AI;
using Tavily;

var tavilyClient = new TavilyClient(
    apiKey: Environment.GetEnvironmentVariable("TAVILY_API_KEY")!);

AIFunction extractTool = tavilyClient.AsExtractTool();

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [extractTool],
};

var response = await chatClient.GetResponseAsync(
    "Summarize the content at https://learn.microsoft.com/en-us/dotnet/ai/",
    options);

Console.WriteLine(response.Text);
```

## Combining Both Tools

You can provide both search and extract tools simultaneously, letting the model decide which to use.

```csharp
using Microsoft.Extensions.AI;
using Tavily;

var tavilyClient = new TavilyClient(
    apiKey: Environment.GetEnvironmentVariable("TAVILY_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        tavilyClient.AsSearchTool(maxResults: 3),
        tavilyClient.AsExtractTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Find a recent article about AI safety and summarize its main points."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchTool()` | `WebSearch` | Searches the web for current information on a given query |
| `AsExtractTool()` | `ExtractWebContent` | Extracts and returns the main content from a given URL |

### AsSearchTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `maxResults` | `int` | `5` | Maximum number of search results |
| `searchDepth` | `RequestSearchDepth` | `Basic` | Search depth (`Basic` or `Advanced`) |
| `includeAnswer` | `bool` | `true` | Include AI-generated answer summary |
