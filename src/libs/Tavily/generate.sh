#!/usr/bin/env bash

set -euo pipefail

# OpenAPI spec: https://docs.tavily.com/documentation/api-reference/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://docs.tavily.com/documentation/api-reference/openapi.json -o openapi.json
autosdk generate openapi.json \
  --namespace Tavily \
  --clientClassName TavilyClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme "Http:Header:Bearer" \
  --exclude-deprecated-operations
