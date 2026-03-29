#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Create a task<br/>
        /// Create a new labeling task. Each task represents an individual unit of work for a labeler.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> CreateTaskAsync(

            global::ScaleAI.CreateTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a task<br/>
        /// Create a new labeling task. Each task represents an individual unit of work for a labeler.
        /// </summary>
        /// <param name="project">
        /// Project name to create this task in.
        /// </param>
        /// <param name="batch">
        /// Batch name to assign this task to.
        /// </param>
        /// <param name="instruction">
        /// Task instruction text (markdown-enabled).
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for task completion notification.
        /// </param>
        /// <param name="attachment">
        /// URL of the attachment (image, video, etc.) to be labeled.
        /// </param>
        /// <param name="attachmentType">
        /// Type of attachment.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata key-value pairs.
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for duplicate prevention.
        /// </param>
        /// <param name="clearUniqueIdOnError">
        /// Automatically clear unique_id if task errors.
        /// </param>
        /// <param name="tags">
        /// Tags to associate with this task.
        /// </param>
        /// <param name="priority">
        /// Task priority.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> CreateTaskAsync(
            string project,
            string? batch = default,
            string? instruction = default,
            string? callbackUrl = default,
            string? attachment = default,
            global::ScaleAI.CreateTaskRequestAttachmentType? attachmentType = default,
            object? metadata = default,
            string? uniqueId = default,
            bool? clearUniqueIdOnError = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            int? priority = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}