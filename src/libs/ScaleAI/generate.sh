#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
# Scale AI API docs: https://scale.com/docs/api-reference/
install_autosdk_cli

rm -rf Generated

# Scale AI uses HTTP Basic Auth (API key as username, empty password).
# We use --security-scheme Http:Header:Bearer for constructor generation,
# then a PrepareRequest hook converts Bearer to Basic auth at runtime.
autosdk generate openapi.yaml \
  --namespace ScaleAI \
  --clientClassName ScaleAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
