#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List tasks<br/>
        /// Returns a paginated list of tasks with optional filtering by project, batch, status, and time range.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="batch"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="completedAfter"></param>
        /// <param name="completedBefore"></param>
        /// <param name="customerReviewStatus"></param>
        /// <param name="limit"></param>
        /// <param name="uniqueId"></param>
        /// <param name="tags"></param>
        /// <param name="includeAttachmentUrl"></param>
        /// <param name="nextToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.TaskListResponse> ListTasksAsync(
            string? project = default,
            string? batch = default,
            global::ScaleAI.ListTasksStatus? status = default,
            string? type = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.DateTime? completedAfter = default,
            global::System.DateTime? completedBefore = default,
            global::ScaleAI.ListTasksCustomerReviewStatus? customerReviewStatus = default,
            int? limit = default,
            string? uniqueId = default,
            string? tags = default,
            bool? includeAttachmentUrl = default,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}