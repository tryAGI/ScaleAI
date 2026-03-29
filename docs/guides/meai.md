# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Scale AI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Scale AI's data labeling project management, task tracking, and batch status monitoring.

## Installation

```bash
dotnet add package ScaleAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `ScaleAI_ListProjects` | List all projects with optional archived filter |
| `AsGetProjectTool()` | `ScaleAI_GetProject` | Get project details by name |
| `AsListTasksTool()` | `ScaleAI_ListTasks` | List labeling tasks with project, batch, and status filtering |
| `AsGetTaskTool()` | `ScaleAI_GetTask` | Get task details by ID including status and instructions |
| `AsGetBatchStatusTool()` | `ScaleAI_GetBatchStatus` | Get batch status with pending and completed task counts |

## Usage

```csharp
using ScaleAI;
using Microsoft.Extensions.AI;

var scaleClient = new ScaleAIClient(
    apiKey: Environment.GetEnvironmentVariable("SCALEAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        scaleClient.AsListProjectsTool(),
        scaleClient.AsGetProjectTool(),
        scaleClient.AsListTasksTool(),
        scaleClient.AsGetTaskTool(),
        scaleClient.AsGetBatchStatusTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all projects and show me the status of pending tasks."),
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
