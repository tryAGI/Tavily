# Tavily

[![Nuget package](https://img.shields.io/nuget/vpre/Tavily)](https://www.nuget.org/packages/Tavily/)
[![dotnet](https://github.com/tryAGI/Tavily/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Tavily/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Tavily)](https://github.com/tryAGI/Tavily/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on the [official Tavily OpenAPI specification](https://docs.tavily.com/documentation/api-reference/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Tavily;

var apiKey =
    Environment.GetEnvironmentVariable("TAVILY_API_KEY") ??
    throw new InvalidOperationException("TAVILY_API_KEY environment variable is not found.");

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

### Microsoft.Extensions.AI

The SDK provides [`AIFunction`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.aifunction) wrappers for use with any `IChatClient`:
```csharp
using Tavily;
using Microsoft.Extensions.AI;

using var tavilyClient = new TavilyClient(tavilyApiKey);

// Create AI tools for search and extract
AIFunction searchTool = tavilyClient.AsSearchTool();
AIFunction extractTool = tavilyClient.AsExtractTool();

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Search for the latest .NET 10 features")],
    new ChatOptions { Tools = [searchTool] });
```

## Support

Priority place for bugs: https://github.com/tryAGI/Tavily/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Tavily/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
