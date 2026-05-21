
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Task type for this project (e.g., imageannotation, textcollection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Unique project name identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of project creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Email of the user who created the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Method used to create the project (api, dashboard).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_with")]
        public string? CreatedWith { get; set; }

        /// <summary>
        /// Pipeline name for Studio projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineName")]
        public string? PipelineName { get; set; }

        /// <summary>
        /// Project type (standard, rapid, studio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectType")]
        public string? ProjectType { get; set; }

        /// <summary>
        /// Number of reviews configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReviews")]
        public int? NumReviews { get; set; }

        /// <summary>
        /// Number of consensus attempts for Studio consensus projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numConsensus")]
        public int? NumConsensus { get; set; }

        /// <summary>
        /// Whether the project is pinned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Whether the project is archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Parameter version history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_history")]
        public global::System.Collections.Generic.IList<global::ScaleAI.ParamHistory>? ParamHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="type">
        /// Task type for this project (e.g., imageannotation, textcollection).
        /// </param>
        /// <param name="name">
        /// Unique project name identifier.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of project creation.
        /// </param>
        /// <param name="createdBy">
        /// Email of the user who created the project.
        /// </param>
        /// <param name="createdWith">
        /// Method used to create the project (api, dashboard).
        /// </param>
        /// <param name="pipelineName">
        /// Pipeline name for Studio projects.
        /// </param>
        /// <param name="projectType">
        /// Project type (standard, rapid, studio).
        /// </param>
        /// <param name="numReviews">
        /// Number of reviews configured.
        /// </param>
        /// <param name="numConsensus">
        /// Number of consensus attempts for Studio consensus projects.
        /// </param>
        /// <param name="pinned">
        /// Whether the project is pinned.
        /// </param>
        /// <param name="archived">
        /// Whether the project is archived.
        /// </param>
        /// <param name="paramHistory">
        /// Parameter version history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string? type,
            string? name,
            global::System.DateTime? createdAt,
            string? createdBy,
            string? createdWith,
            string? pipelineName,
            string? projectType,
            int? numReviews,
            int? numConsensus,
            bool? pinned,
            bool? archived,
            global::System.Collections.Generic.IList<global::ScaleAI.ParamHistory>? paramHistory)
        {
            this.Type = type;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.CreatedWith = createdWith;
            this.PipelineName = pipelineName;
            this.ProjectType = projectType;
            this.NumReviews = numReviews;
            this.NumConsensus = numConsensus;
            this.Pinned = pinned;
            this.Archived = archived;
            this.ParamHistory = paramHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }

    }
}