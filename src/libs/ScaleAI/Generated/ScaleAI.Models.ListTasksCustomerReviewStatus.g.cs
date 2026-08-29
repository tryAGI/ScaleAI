
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListTasksCustomerReviewStatus
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
    public static class ListTasksCustomerReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTasksCustomerReviewStatus value)
        {
            return value switch
            {
                ListTasksCustomerReviewStatus.Accepted => "accepted",
                ListTasksCustomerReviewStatus.Commented => "commented",
                ListTasksCustomerReviewStatus.Fixed => "fixed",
                ListTasksCustomerReviewStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTasksCustomerReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ListTasksCustomerReviewStatus.Accepted,
                "commented" => ListTasksCustomerReviewStatus.Commented,
                "fixed" => ListTasksCustomerReviewStatus.Fixed,
                "rejected" => ListTasksCustomerReviewStatus.Rejected,
                _ => null,
            };
        }
    }
}