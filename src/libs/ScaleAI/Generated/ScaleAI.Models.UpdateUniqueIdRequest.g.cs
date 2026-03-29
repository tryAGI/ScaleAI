
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUniqueIdRequest
    {
        /// <summary>
        /// New unique_id value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UniqueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUniqueIdRequest" /> class.
        /// </summary>
        /// <param name="uniqueId">
        /// New unique_id value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUniqueIdRequest(
            string uniqueId)
        {
            this.UniqueId = uniqueId ?? throw new global::System.ArgumentNullException(nameof(uniqueId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUniqueIdRequest" /> class.
        /// </summary>
        public UpdateUniqueIdRequest()
        {
        }
    }
}