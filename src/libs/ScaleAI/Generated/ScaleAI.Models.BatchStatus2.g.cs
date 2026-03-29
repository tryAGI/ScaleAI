
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchStatus2
    {
        /// <summary>
        /// Current batch status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.BatchStatusStatusJsonConverter))]
        public global::ScaleAI.BatchStatusStatus? Status { get; set; }

        /// <summary>
        /// Number of pending tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_pending")]
        public int? TasksPending { get; set; }

        /// <summary>
        /// Number of completed tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_completed")]
        public int? TasksCompleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatus2" /> class.
        /// </summary>
        /// <param name="status">
        /// Current batch status.
        /// </param>
        /// <param name="tasksPending">
        /// Number of pending tasks.
        /// </param>
        /// <param name="tasksCompleted">
        /// Number of completed tasks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchStatus2(
            global::ScaleAI.BatchStatusStatus? status,
            int? tasksPending,
            int? tasksCompleted)
        {
            this.Status = status;
            this.TasksPending = tasksPending;
            this.TasksCompleted = tasksCompleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatus2" /> class.
        /// </summary>
        public BatchStatus2()
        {
        }
    }
}