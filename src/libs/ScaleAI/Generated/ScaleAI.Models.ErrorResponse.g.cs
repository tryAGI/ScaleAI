
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code.
        /// </param>
        /// <param name="error">
        /// Error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            int? statusCode,
            string? error)
        {
            this.StatusCode = statusCode;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}