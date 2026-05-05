#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Add tags to a task<br/>
        /// Add tags to a task. Tags are used for organizing and filtering tasks.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Task> AddTaskTagsAsync(
            string taskId,

            global::System.Collections.Generic.IList<string> request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add tags to a task<br/>
        /// Add tags to a task. Tags are used for organizing and filtering tasks.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.Task>> AddTaskTagsAsResponseAsync(
            string taskId,

            global::System.Collections.Generic.IList<string> request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}