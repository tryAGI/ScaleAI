
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequest
    {
        /// <summary>
        /// Project name to create this task in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// Batch name to assign this task to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public string? Batch { get; set; }

        /// <summary>
        /// Task instruction text (markdown-enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Webhook URL for task completion notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// URL of the attachment (image, video, etc.) to be labeled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment")]
        public string? Attachment { get; set; }

        /// <summary>
        /// Type of attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.CreateTaskRequestAttachmentTypeJsonConverter))]
        public global::ScaleAI.CreateTaskRequestAttachmentType? AttachmentType { get; set; }

        /// <summary>
        /// Custom metadata key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Unique identifier for duplicate prevention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Automatically clear unique_id if task errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_unique_id_on_error")]
        public bool? ClearUniqueIdOnError { get; set; }

        /// <summary>
        /// Tags to associate with this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Task priority.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequest(
            string project,
            string? batch,
            string? instruction,
            string? callbackUrl,
            string? attachment,
            global::ScaleAI.CreateTaskRequestAttachmentType? attachmentType,
            object? metadata,
            string? uniqueId,
            bool? clearUniqueIdOnError,
            global::System.Collections.Generic.IList<string>? tags,
            int? priority)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Batch = batch;
            this.Instruction = instruction;
            this.CallbackUrl = callbackUrl;
            this.Attachment = attachment;
            this.AttachmentType = attachmentType;
            this.Metadata = metadata;
            this.UniqueId = uniqueId;
            this.ClearUniqueIdOnError = clearUniqueIdOnError;
            this.Tags = tags;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequest" /> class.
        /// </summary>
        public CreateTaskRequest()
        {
        }
    }
}