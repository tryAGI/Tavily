dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Tavily \
  TavilyClient \
  https://raw.githubusercontent.com/davidmigloz/langchain_dart/refs/heads/main/packages/tavily_dart/oas/tavily_openapi.yaml \
  tryAGI \
  --output .
