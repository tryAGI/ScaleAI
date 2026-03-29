
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public global::System.Collections.Generic.IList<global::ScaleAI.Task>? Docs { get; set; }

        /// <summary>
        /// Total number of matching tasks.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Pagination token for next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_token")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        /// <param name="docs"></param>
        /// <param name="total">
        /// Total number of matching tasks.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="hasMore"></param>
        /// <param name="nextToken">
        /// Pagination token for next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListResponse(
            global::System.Collections.Generic.IList<global::ScaleAI.Task>? docs,
            int? total,
            int? limit,
            bool? hasMore,
            string? nextToken)
        {
            this.Docs = docs;
            this.Total = total;
            this.Limit = limit;
            this.HasMore = hasMore;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        public TaskListResponse()
        {
        }
    }
}