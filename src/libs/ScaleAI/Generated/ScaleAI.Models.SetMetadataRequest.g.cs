
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Key-value pairs to set as task metadata.
    /// </summary>
    public sealed partial class SetMetadataRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}