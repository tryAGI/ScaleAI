
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Current task status.
    /// </summary>
    public enum TaskStatus
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatus value)
        {
            return value switch
            {
                TaskStatus.Canceled => "canceled",
                TaskStatus.Completed => "completed",
                TaskStatus.Error => "error",
                TaskStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => TaskStatus.Canceled,
                "completed" => TaskStatus.Completed,
                "error" => TaskStatus.Error,
                "pending" => TaskStatus.Pending,
                _ => null,
            };
        }
    }
}