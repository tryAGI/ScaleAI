#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Update task unique_id<br/>
        /// Update the unique_id of a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> UpdateTaskUniqueIdAsync(
            string taskId,

            global::ScaleAI.UpdateUniqueIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task unique_id<br/>
        /// Update the unique_id of a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="uniqueId">
        /// New unique_id value.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> UpdateTaskUniqueIdAsync(
            string taskId,
            string uniqueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}