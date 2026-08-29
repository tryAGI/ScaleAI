
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Team role.
    /// </summary>
    public enum TeamMemberRole
    {
        /// <summary>
        ///
        /// </summary>
        Labeler,
        /// <summary>
        ///
        /// </summary>
        Manager,
        /// <summary>
        ///
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMemberRole value)
        {
            return value switch
            {
                TeamMemberRole.Labeler => "labeler",
                TeamMemberRole.Manager => "manager",
                TeamMemberRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "labeler" => TeamMemberRole.Labeler,
                "manager" => TeamMemberRole.Manager,
                "member" => TeamMemberRole.Member,
                _ => null,
            };
        }
    }
}