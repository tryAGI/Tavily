#!/usr/bin/env bash

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

set -euo pipefail

# OpenAPI spec: https://docs.tavily.com/documentation/api-reference/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://docs.tavily.com/documentation/api-reference/openapi.json -o openapi.json
autosdk generate openapi.json \
  --namespace Tavily \
  --clientClassName TavilyClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme "Http:Header:Bearer" \
  --exclude-deprecated-operations
