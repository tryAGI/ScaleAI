
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// New role to assign.
    /// </summary>
    public enum SetRoleRequestTeamRole
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
    public static class SetRoleRequestTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetRoleRequestTeamRole value)
        {
            return value switch
            {
                SetRoleRequestTeamRole.Labeler => "labeler",
                SetRoleRequestTeamRole.Manager => "manager",
                SetRoleRequestTeamRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetRoleRequestTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "labeler" => SetRoleRequestTeamRole.Labeler,
                "manager" => SetRoleRequestTeamRole.Manager,
                "member" => SetRoleRequestTeamRole.Member,
                _ => null,
            };
        }
    }
}