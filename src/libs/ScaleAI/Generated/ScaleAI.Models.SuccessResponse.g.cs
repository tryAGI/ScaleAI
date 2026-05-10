
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuccessResponse
    {
        /// <summary>
        /// Result status message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse" /> class.
        /// </summary>
        /// <param name="result">
        /// Result status message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuccessResponse(
            string? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse" /> class.
        /// </summary>
        public SuccessResponse()
        {
        }

    }
}