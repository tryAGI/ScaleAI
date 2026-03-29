
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextCollectionTaskRequest
    {
        /// <summary>
        /// Project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Batch name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public string? Batch { get; set; }

        /// <summary>
        /// Task instruction text (markdown-enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Webhook URL for task completion notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Array of fields for data collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionField> Fields { get; set; }

        /// <summary>
        /// Attachments for context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionAttachment>? Attachments { get; set; }

        /// <summary>
        /// Task title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Task description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Number of responses required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses_required")]
        public int? ResponsesRequired { get; set; }

        /// <summary>
        /// Task priority.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Unique identifier for duplicate prevention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Automatically clear unique_id on error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_unique_id_on_error")]
        public bool? ClearUniqueIdOnError { get; set; }

        /// <summary>
        /// Tags for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextCollectionTaskRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// Task instruction text (markdown-enabled).
        /// </param>
        /// <param name="fields">
        /// Array of fields for data collection.
        /// </param>
        /// <param name="project">
        /// Project name.
        /// </param>
        /// <param name="batch">
        /// Batch name.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for task completion notification.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextCollectionTaskRequest(
            string instruction,
            global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionField> fields,
            string? project,
            string? batch,
            string? callbackUrl,
            global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionAttachment>? attachments,
            string? title,
            string? description,
            int? responsesRequired,
            int? priority,
            string? uniqueId,
            bool? clearUniqueIdOnError,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Project = project;
            this.Batch = batch;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.CallbackUrl = callbackUrl;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Attachments = attachments;
            this.Title = title;
            this.Description = description;
            this.ResponsesRequired = responsesRequired;
            this.Priority = priority;
            this.UniqueId = uniqueId;
            this.ClearUniqueIdOnError = clearUniqueIdOnError;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextCollectionTaskRequest" /> class.
        /// </summary>
        public CreateTextCollectionTaskRequest()
        {
        }
    }
}