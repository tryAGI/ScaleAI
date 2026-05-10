
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamMember
    {
        /// <summary>
        /// Team member email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Team role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.TeamMemberRoleJsonConverter))]
        public global::ScaleAI.TeamMemberRole? Role { get; set; }

        /// <summary>
        /// Whether the member is a Studio labeler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStudioLabeler")]
        public bool? IsStudioLabeler { get; set; }

        /// <summary>
        /// Whether rapid emails are disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableRapidEmails")]
        public bool? DisableRapidEmails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        /// <param name="email">
        /// Team member email address.
        /// </param>
        /// <param name="firstName">
        /// First name.
        /// </param>
        /// <param name="lastName">
        /// Last name.
        /// </param>
        /// <param name="company">
        /// Company name.
        /// </param>
        /// <param name="role">
        /// Team role.
        /// </param>
        /// <param name="isStudioLabeler">
        /// Whether the member is a Studio labeler.
        /// </param>
        /// <param name="disableRapidEmails">
        /// Whether rapid emails are disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMember(
            string? email,
            string? firstName,
            string? lastName,
            string? company,
            global::ScaleAI.TeamMemberRole? role,
            bool? isStudioLabeler,
            bool? disableRapidEmails)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.Role = role;
            this.IsStudioLabeler = isStudioLabeler;
            this.DisableRapidEmails = disableRapidEmails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        public TeamMember()
        {
        }

    }
}