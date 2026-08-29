
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListBatchesStatus
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
    public static class ListBatchesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchesStatus value)
        {
            return value switch
            {
                ListBatchesStatus.Completed => "completed",
                ListBatchesStatus.InProgress => "in_progress",
                ListBatchesStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchesStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListBatchesStatus.Completed,
                "in_progress" => ListBatchesStatus.InProgress,
                "staging" => ListBatchesStatus.Staging,
                _ => null,
            };
        }
    }
}