
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBatchRequest
    {
        /// <summary>
        /// Project name to create this batch in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// Unique batch name identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Webhook URL or email for batch completion notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// Whether this is a calibration batch (Rapid projects).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibration_batch")]
        public bool? CalibrationBatch { get; set; }

        /// <summary>
        /// Whether this is a self-label batch (Rapid projects).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_label_batch")]
        public bool? SelfLabelBatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="project">
        /// Project name to create this batch in.
        /// </param>
        /// <param name="name">
        /// Unique batch name identifier.
        /// </param>
        /// <param name="callback">
        /// Webhook URL or email for batch completion notification.
        /// </param>
        /// <param name="calibrationBatch">
        /// Whether this is a calibration batch (Rapid projects).
        /// </param>
        /// <param name="selfLabelBatch">
        /// Whether this is a self-label batch (Rapid projects).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchRequest(
            string project,
            string name,
            string? callback,
            bool? calibrationBatch,
            bool? selfLabelBatch)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Callback = callback;
            this.CalibrationBatch = calibrationBatch;
            this.SelfLabelBatch = selfLabelBatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        public CreateBatchRequest()
        {
        }

    }
}