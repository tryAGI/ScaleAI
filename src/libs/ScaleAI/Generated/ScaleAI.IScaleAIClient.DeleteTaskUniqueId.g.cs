#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Delete task unique_id<br/>
        /// Remove the unique_id from a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> DeleteTaskUniqueIdAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}