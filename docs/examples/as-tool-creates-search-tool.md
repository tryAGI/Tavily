# As Tool Creates Search Tool



This example assumes `using Tavily;` is in scope and `apiKey` contains your Tavily API key.

```csharp
using var client = CreateTestClient();

var tool = client.AsSearchTool();
```