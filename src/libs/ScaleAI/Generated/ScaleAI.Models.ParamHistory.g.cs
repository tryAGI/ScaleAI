
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParamHistory
    {
        /// <summary>
        /// Task instruction text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Parameter version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when this version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamHistory" /> class.
        /// </summary>
        /// <param name="instruction">
        /// Task instruction text.
        /// </param>
        /// <param name="version">
        /// Parameter version number.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when this version was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParamHistory(
            string? instruction,
            int? version,
            global::System.DateTime? createdAt)
        {
            this.Instruction = instruction;
            this.Version = version;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamHistory" /> class.
        /// </summary>
        public ParamHistory()
        {
        }
    }
}