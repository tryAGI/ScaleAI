
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Current batch status.
    /// </summary>
    public enum BatchStatus2
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
    public static class BatchStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus2 value)
        {
            return value switch
            {
                BatchStatus2.Completed => "completed",
                BatchStatus2.InProgress => "in_progress",
                BatchStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BatchStatus2.Completed,
                "in_progress" => BatchStatus2.InProgress,
                "staging" => BatchStatus2.Staging,
                _ => null,
            };
        }
    }
}