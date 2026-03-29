#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Set batch priority<br/>
        /// Set the priority of a batch. Higher priority batches are processed first.
        /// </summary>
        /// <param name="batchName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.SuccessResponse> PrioritizeBatchAsync(
            string batchName,

            global::ScaleAI.BatchPrioritizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set batch priority<br/>
        /// Set the priority of a batch. Higher priority batches are processed first.
        /// </summary>
        /// <param name="batchName"></param>
        /// <param name="priority">
        /// Priority value between 10 (lowest) and 30 (highest).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.SuccessResponse> PrioritizeBatchAsync(
            string batchName,
            int priority,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}