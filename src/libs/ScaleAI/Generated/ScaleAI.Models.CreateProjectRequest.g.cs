
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectRequest
    {
        /// <summary>
        /// Task type: imageannotation, textcollection, namedentityrecognition, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.CreateProjectRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScaleAI.CreateProjectRequestType Type { get; set; }

        /// <summary>
        /// Unique project name identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this is a Scale Rapid project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rapid")]
        public bool? Rapid { get; set; }

        /// <summary>
        /// Whether this is a Scale Studio project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio")]
        public bool? Studio { get; set; }

        /// <summary>
        /// Default task parameters for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Pipeline type for Studio projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.CreateProjectRequestPipelineJsonConverter))]
        public global::ScaleAI.CreateProjectRequestPipeline? Pipeline { get; set; }

        /// <summary>
        /// Number of consensus attempts (Studio consensus projects only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_attempts")]
        public int? ConsensusAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Task type: imageannotation, textcollection, namedentityrecognition, etc.
        /// </param>
        /// <param name="name">
        /// Unique project name identifier.
        /// </param>
        /// <param name="rapid">
        /// Whether this is a Scale Rapid project.
        /// </param>
        /// <param name="studio">
        /// Whether this is a Scale Studio project.
        /// </param>
        /// <param name="params">
        /// Default task parameters for this project.
        /// </param>
        /// <param name="pipeline">
        /// Pipeline type for Studio projects.
        /// </param>
        /// <param name="consensusAttempts">
        /// Number of consensus attempts (Studio consensus projects only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequest(
            global::ScaleAI.CreateProjectRequestType type,
            string name,
            bool? rapid,
            bool? studio,
            object? @params,
            global::ScaleAI.CreateProjectRequestPipeline? pipeline,
            int? consensusAttempts)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Rapid = rapid;
            this.Studio = studio;
            this.Params = @params;
            this.Pipeline = pipeline;
            this.ConsensusAttempts = consensusAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        public CreateProjectRequest()
        {
        }

    }
}