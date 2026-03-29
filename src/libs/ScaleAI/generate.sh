#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)
# Scale AI API docs: https://scale.com/docs/api-reference/

dotnet tool install --global autosdk.cli --prerelease

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
