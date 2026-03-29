#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Retrieve a task<br/>
        /// Get details of a specific task by ID.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> GetTaskAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}