
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnassignTeamRequest
    {
        /// <summary>
        /// Email addresses of teammates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Project names to unassign from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<string>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnassignTeamRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses of teammates.
        /// </param>
        /// <param name="projects">
        /// Project names to unassign from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnassignTeamRequest(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string>? projects)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnassignTeamRequest" /> class.
        /// </summary>
        public UnassignTeamRequest()
        {
        }
    }
}