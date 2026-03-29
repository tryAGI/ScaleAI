#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Create a text collection task<br/>
        /// Create a GenAI text collection task for data collection, RLHF, or evaluation workflows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> CreateTextCollectionTaskAsync(

            global::ScaleAI.CreateTextCollectionTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a text collection task<br/>
        /// Create a GenAI text collection task for data collection, RLHF, or evaluation workflows.
        /// </summary>
        /// <param name="project">
        /// Project name.
        /// </param>
        /// <param name="batch">
        /// Batch name.
        /// </param>
        /// <param name="instruction">
        /// Task instruction text (markdown-enabled).
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for task completion notification.
        /// </param>
        /// <param name="fields">
        /// Array of fields for data collection.
        /// </param>
        /// <param name="attachments">
        /// Attachments for context.
        /// </param>
        /// <param name="title">
        /// Task title.
        /// </param>
        /// <param name="description">
        /// Task description.
        /// </param>
        /// <param name="responsesRequired">
        /// Number of responses required.
        /// </param>
        /// <param name="priority">
        /// Task priority.
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for duplicate prevention.
        /// </param>
        /// <param name="clearUniqueIdOnError">
        /// Automatically clear unique_id on error.
        /// </param>
        /// <param name="tags">
        /// Tags for this task.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> CreateTextCollectionTaskAsync(
            string instruction,
            global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionField> fields,
            string? project = default,
            string? batch = default,
            string? callbackUrl = default,
            global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionAttachment>? attachments = default,
            string? title = default,
            string? description = default,
            int? responsesRequired = default,
            int? priority = default,
            string? uniqueId = default,
            bool? clearUniqueIdOnError = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}