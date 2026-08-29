
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Current batch status.
    /// </summary>
    public enum BatchStatus
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
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Completed => "completed",
                BatchStatus.InProgress => "in_progress",
                BatchStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BatchStatus.Completed,
                "in_progress" => BatchStatus.InProgress,
                "staging" => BatchStatus.Staging,
                _ => null,
            };
        }
    }
}