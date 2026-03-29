#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Set task metadata<br/>
        /// Set custom key-value metadata on a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> SetTaskMetadataAsync(
            string taskId,

            global::ScaleAI.SetMetadataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set task metadata<br/>
        /// Set custom key-value metadata on a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> SetTaskMetadataAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}