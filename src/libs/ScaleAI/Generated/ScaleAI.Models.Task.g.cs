
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Task
    {
        /// <summary>
        /// Unique task identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of task creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of task completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Task type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Current task status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.TaskStatusJsonConverter))]
        public global::ScaleAI.TaskStatus? Status { get; set; }

        /// <summary>
        /// Task instruction text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Webhook URL for task completion notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Task-specific parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Task response/result from the labeler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

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
        /// Tags associated with this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Customer review status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_review_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.TaskCustomerReviewStatusJsonConverter))]
        public global::ScaleAI.TaskCustomerReviewStatus? CustomerReviewStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task identifier.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of task creation.
        /// </param>
        /// <param name="completedAt">
        /// ISO 8601 timestamp of task completion.
        /// </param>
        /// <param name="type">
        /// Task type.
        /// </param>
        /// <param name="status">
        /// Current task status.
        /// </param>
        /// <param name="instruction">
        /// Task instruction text.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for task completion notification.
        /// </param>
        /// <param name="params">
        /// Task-specific parameters.
        /// </param>
        /// <param name="response">
        /// Task response/result from the labeler.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata key-value pairs.
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for duplicate prevention.
        /// </param>
        /// <param name="tags">
        /// Tags associated with this task.
        /// </param>
        /// <param name="customerReviewStatus">
        /// Customer review status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Task(
            string? taskId,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? type,
            global::ScaleAI.TaskStatus? status,
            string? instruction,
            string? callbackUrl,
            object? @params,
            object? response,
            object? metadata,
            string? uniqueId,
            global::System.Collections.Generic.IList<string>? tags,
            global::ScaleAI.TaskCustomerReviewStatus? customerReviewStatus)
        {
            this.TaskId = taskId;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Type = type;
            this.Status = status;
            this.Instruction = instruction;
            this.CallbackUrl = callbackUrl;
            this.Params = @params;
            this.Response = response;
            this.Metadata = metadata;
            this.UniqueId = uniqueId;
            this.Tags = tags;
            this.CustomerReviewStatus = customerReviewStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        public Task()
        {
        }

    }
}