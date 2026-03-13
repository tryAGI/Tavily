dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Tavily \
  TavilyClient \
  https://docs.tavily.com/documentation/api-reference/openapi.json \
  tryAGI \
  --output .
