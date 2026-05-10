
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// Project name this batch belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Unique batch name identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Webhook URL or email for batch completion notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// Current batch status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.BatchStatusJsonConverter))]
        public global::ScaleAI.BatchStatus? Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of batch creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="project">
        /// Project name this batch belongs to.
        /// </param>
        /// <param name="name">
        /// Unique batch name identifier.
        /// </param>
        /// <param name="callback">
        /// Webhook URL or email for batch completion notification.
        /// </param>
        /// <param name="status">
        /// Current batch status.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of batch creation.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string? project,
            string? name,
            string? callback,
            global::ScaleAI.BatchStatus? status,
            global::System.DateTime? createdAt,
            object? metadata)
        {
            this.Project = project;
            this.Name = name;
            this.Callback = callback;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }

    }
}