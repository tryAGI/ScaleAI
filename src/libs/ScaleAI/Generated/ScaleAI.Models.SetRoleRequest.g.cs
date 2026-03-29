
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetRoleRequest
    {
        /// <summary>
        /// Email addresses to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// New role to assign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.SetRoleRequestTeamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScaleAI.SetRoleRequestTeamRole TeamRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetRoleRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to update.
        /// </param>
        /// <param name="teamRole">
        /// New role to assign.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetRoleRequest(
            global::System.Collections.Generic.IList<string> emails,
            global::ScaleAI.SetRoleRequestTeamRole teamRole)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.TeamRole = teamRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetRoleRequest" /> class.
        /// </summary>
        public SetRoleRequest()
        {
        }
    }
}