
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectParamsRequest
    {
        /// <summary>
        /// If true, merge with existing params instead of replacing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public bool? Patch { get; set; }

        /// <summary>
        /// Instruction text to append to task instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectParamsRequest" /> class.
        /// </summary>
        /// <param name="patch">
        /// If true, merge with existing params instead of replacing.
        /// </param>
        /// <param name="instruction">
        /// Instruction text to append to task instructions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectParamsRequest(
            bool? patch,
            string? instruction)
        {
            this.Patch = patch;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectParamsRequest" /> class.
        /// </summary>
        public UpdateProjectParamsRequest()
        {
        }

    }
}