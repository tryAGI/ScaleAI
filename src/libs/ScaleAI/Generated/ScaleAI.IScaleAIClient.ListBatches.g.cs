#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List all batches<br/>
        /// Returns a paginated list of all batches, optionally filtered by project or status.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="status"></param>
        /// <param name="detailed"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.BatchListResponse> ListBatchesAsync(
            string? project = default,
            global::ScaleAI.ListBatchesStatus? status = default,
            bool? detailed = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            int? offset = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}