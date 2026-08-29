
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Current batch status.
    /// </summary>
    public enum BatchStatusStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatusStatus value)
        {
            return value switch
            {
                BatchStatusStatus.Completed => "completed",
                BatchStatusStatus.InProgress => "in_progress",
                BatchStatusStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BatchStatusStatus.Completed,
                "in_progress" => BatchStatusStatus.InProgress,
                "staging" => BatchStatusStatus.Staging,
                _ => null,
            };
        }
    }
}