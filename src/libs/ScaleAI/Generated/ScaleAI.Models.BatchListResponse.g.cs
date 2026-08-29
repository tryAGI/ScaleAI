
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public global::System.Collections.Generic.IList<global::ScaleAI.Batch>? Docs { get; set; }

        /// <summary>
        /// Total number of batches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchListResponse" /> class.
        /// </summary>
        /// <param name="docs"></param>
        /// <param name="total">
        /// Total number of batches.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchListResponse(
            global::System.Collections.Generic.IList<global::ScaleAI.Batch>? docs,
            int? total,
            int? limit,
            int? offset,
            bool? hasMore)
        {
            this.Docs = docs;
            this.Total = total;
            this.Limit = limit;
            this.Offset = offset;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchListResponse" /> class.
        /// </summary>
        public BatchListResponse()
        {
        }

    }
}