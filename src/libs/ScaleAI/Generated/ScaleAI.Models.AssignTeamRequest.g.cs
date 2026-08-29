
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignTeamRequest
    {
        /// <summary>
        /// Email addresses of teammates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Project names to assign to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTeamRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses of teammates.
        /// </param>
        /// <param name="projects">
        /// Project names to assign to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignTeamRequest(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string> projects)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTeamRequest" /> class.
        /// </summary>
        public AssignTeamRequest()
        {
        }

    }
}