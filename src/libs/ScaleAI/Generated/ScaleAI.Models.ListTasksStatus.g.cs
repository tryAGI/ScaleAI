
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTasksStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTasksStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTasksStatus value)
        {
            return value switch
            {
                ListTasksStatus.Canceled => "canceled",
                ListTasksStatus.Completed => "completed",
                ListTasksStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTasksStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListTasksStatus.Canceled,
                "completed" => ListTasksStatus.Completed,
                "pending" => ListTasksStatus.Pending,
                _ => null,
            };
        }
    }
}