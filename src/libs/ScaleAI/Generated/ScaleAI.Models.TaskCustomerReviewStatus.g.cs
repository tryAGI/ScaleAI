
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Customer review status.
    /// </summary>
    public enum TaskCustomerReviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Commented,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskCustomerReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskCustomerReviewStatus value)
        {
            return value switch
            {
                TaskCustomerReviewStatus.Accepted => "accepted",
                TaskCustomerReviewStatus.Commented => "commented",
                TaskCustomerReviewStatus.Fixed => "fixed",
                TaskCustomerReviewStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskCustomerReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => TaskCustomerReviewStatus.Accepted,
                "commented" => TaskCustomerReviewStatus.Commented,
                "fixed" => TaskCustomerReviewStatus.Fixed,
                "rejected" => TaskCustomerReviewStatus.Rejected,
                _ => null,
            };
        }
    }
}