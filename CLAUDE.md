# CLAUDE.md -- ScaleAI SDK

## Overview

Auto-generated C# SDK for [Scale AI](https://scale.com/) -- data labeling, RLHF, and AI evaluation platform.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from [Scale AI API docs](https://scale.com/docs/api-reference/).

## Build & Test

```bash
dotnet build ScaleAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Scale AI uses HTTP Basic Auth (API key as username, empty password).
Constructor uses Bearer internally, converted via `PrepareRequest` hook to Basic auth:

```csharp
var client = new ScaleAIClient(apiKey); // SCALEAI_API_KEY env var
```

## Key Files

- `src/libs/ScaleAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Scale AI)
- `src/libs/ScaleAI/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer` (no download step)
- `src/libs/ScaleAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/ScaleAI/Extensions/ScaleAIClient.PrepareRequest.cs` -- Auth hook (Bearer -> Basic)
- `src/libs/ScaleAI/Extensions/ScaleAIClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Endpoints

| Category | Endpoint | Method | Description |
|----------|----------|--------|-------------|
| Projects | `/projects` | GET | List all projects |
| Projects | `/projects` | POST | Create a project |
| Projects | `/projects/{name}` | GET | Get project details |
| Projects | `/projects/{name}/setParams` | POST | Update project parameters |
| Batches | `/batches` | GET | List all batches |
| Batches | `/batches` | POST | Create a batch |
| Batches | `/batches/{name}` | GET | Get batch details |
| Batches | `/batches/{name}/status` | GET | Get batch task counts |
| Batches | `/batches/{name}/finalize` | POST | Finalize a batch |
| Batches | `/batches/{name}/prioritize` | POST | Set batch priority |
| Tasks | `/task` | POST | Create a task |
| Tasks | `/tasks` | GET | List tasks (filtered) |
| Tasks | `/task/{id}` | GET | Get task details |
| Tasks | `/task/{id}/cancel` | POST | Cancel a task |
| Tasks | `/task/{id}/setMetadata` | POST | Set task metadata |
| Tasks | `/task/{id}/unique_id` | POST | Update task unique_id |
| Tasks | `/task/{id}/unique_id` | DELETE | Delete task unique_id |
| Tasks | `/task/{id}/tags` | POST | Add task tags |
| Tasks | `/task/{id}/tags` | DELETE | Remove task tags |
| GenAI | `/task/textcollection` | POST | Create text collection task |
| Files | `/files/upload` | POST | Upload a file |
| Files | `/files/import` | POST | Import file from URL |
| Teams | `/teams` | GET | List team members |
| Teams | `/teams/invite` | POST | Invite teammates |
| Teams | `/teams/set_role` | POST | Update teammate role |
| Studio | `/studio/assignments` | GET | List assignments |
| Studio | `/studio/assignments/add` | POST | Assign teammates |
| Studio | `/studio/assignments/remove` | POST | Unassign teammates |
| Studio | `/studio/batches` | GET | List Studio batches |
| Studio | `/studio/batches/set_priorities` | POST | Set batch priorities |
| Studio | `/studio/batches/reset_priorities` | POST | Reset batch priorities |
| Studio | `/studio/projects/{name}/groups` | GET | List project groups |
| Studio | `/studio/projects/{name}/groups` | POST | Create project group |
| Quality | `/quality/labelers` | GET | List training attempts |

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListProjectsTool()` -- List all projects with optional archived filter
- `AsGetProjectTool()` -- Get project details by name
- `AsListTasksTool()` -- List tasks with project/batch/status filtering
- `AsGetTaskTool()` -- Get task details by ID
- `AsGetBatchStatusTool()` -- Get batch status with task counts

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Scale AI API docs
- Base URL: `https://api.scale.com/v1`
- Auth: HTTP Basic Auth (API key as username, empty password)
- `PrepareRequest` hook converts Bearer token to `Authorization: Basic <base64(apiKey:)>`
- The API does not support bulk updates; each request works on a single object
