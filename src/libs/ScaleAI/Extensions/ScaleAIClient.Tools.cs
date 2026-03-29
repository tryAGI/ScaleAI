#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace ScaleAI;

public static class ScaleAIClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists all projects.
    /// </summary>
    public static AIFunction AsListProjectsTool(this ScaleAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("If true, include archived projects")] bool? archived,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ListProjectsAsync(
                    archived: archived,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "ScaleAI_ListProjects",
            description: "List all Scale AI projects in the account, optionally filtered by archived status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves a specific project by name.
    /// </summary>
    public static AIFunction AsGetProjectTool(this ScaleAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The unique project name")] string projectName,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetProjectAsync(
                    projectName: projectName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Type,
                    response.Name,
                    response.CreatedAt,
                    response.CreatedBy,
                    response.ProjectType,
                    response.Archived,
                    response.Pinned,
                };
            },
            name: "ScaleAI_GetProject",
            description: "Get details of a specific Scale AI project by name, including type, creation info, and status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists tasks with filtering.
    /// </summary>
    public static AIFunction AsListTasksTool(this ScaleAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Filter by project name")] string? project,
                   [Description("Filter by batch name")] string? batch,
                   [Description("Filter by status: pending, completed, canceled")] string? status,
                   [Description("Maximum number of tasks to return (1-100)")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var statusEnum = status switch
                {
                    _ when string.Equals(status, "pending", StringComparison.OrdinalIgnoreCase) => ListTasksStatus.Pending,
                    _ when string.Equals(status, "completed", StringComparison.OrdinalIgnoreCase) => ListTasksStatus.Completed,
                    _ when string.Equals(status, "canceled", StringComparison.OrdinalIgnoreCase) => ListTasksStatus.Canceled,
                    _ => (ListTasksStatus?)null,
                };

                var response = await client.ListTasksAsync(
                    project: project,
                    batch: batch,
                    status: statusEnum,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Total,
                    response.HasMore,
                    Tasks = response.Docs?.Select(t => new
                    {
                        t.TaskId,
                        t.Type,
                        Status = t.Status?.ToString(),
                        t.CreatedAt,
                        t.CompletedAt,
                    }).ToArray(),
                };
            },
            name: "ScaleAI_ListTasks",
            description: "List Scale AI labeling tasks with optional filtering by project, batch, and status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves a specific task by ID.
    /// </summary>
    public static AIFunction AsGetTaskTool(this ScaleAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The task ID to retrieve")] string taskId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetTaskAsync(
                    taskId: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.TaskId,
                    response.Type,
                    Status = response.Status?.ToString(),
                    response.Instruction,
                    response.CreatedAt,
                    response.CompletedAt,
                    response.UniqueId,
                    response.Tags,
                    CustomerReviewStatus = response.CustomerReviewStatus?.ToString(),
                };
            },
            name: "ScaleAI_GetTask",
            description: "Get details of a specific Scale AI labeling task by ID, including status, instructions, and results.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status of a batch.
    /// </summary>
    public static AIFunction AsGetBatchStatusTool(this ScaleAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The batch name to check status for")] string batchName,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetBatchStatusAsync(
                    batchName: batchName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Status = response.Status?.ToString(),
                    response.TasksPending,
                    response.TasksCompleted,
                };
            },
            name: "ScaleAI_GetBatchStatus",
            description: "Get the status of a Scale AI batch including counts of pending and completed tasks.");
    }
}
