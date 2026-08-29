
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Role to assign.
    /// </summary>
    public enum InviteTeamRequestTeamRole
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
    public static class InviteTeamRequestTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteTeamRequestTeamRole value)
        {
            return value switch
            {
                InviteTeamRequestTeamRole.Labeler => "labeler",
                InviteTeamRequestTeamRole.Manager => "manager",
                InviteTeamRequestTeamRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteTeamRequestTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "labeler" => InviteTeamRequestTeamRole.Labeler,
                "manager" => InviteTeamRequestTeamRole.Manager,
                "member" => InviteTeamRequestTeamRole.Member,
                _ => null,
            };
        }
    }
}