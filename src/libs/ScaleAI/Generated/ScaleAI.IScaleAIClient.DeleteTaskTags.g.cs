#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Remove tags from a task<br/>
        /// Remove specific tags from a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> DeleteTaskTagsAsync(
            string taskId,

            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}