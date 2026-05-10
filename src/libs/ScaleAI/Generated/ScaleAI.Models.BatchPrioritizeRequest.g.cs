
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchPrioritizeRequest
    {
        /// <summary>
        /// Priority value between 10 (lowest) and 30 (highest).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPrioritizeRequest" /> class.
        /// </summary>
        /// <param name="priority">
        /// Priority value between 10 (lowest) and 30 (highest).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchPrioritizeRequest(
            int priority)
        {
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPrioritizeRequest" /> class.
        /// </summary>
        public BatchPrioritizeRequest()
        {
        }

    }
}